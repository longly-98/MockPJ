
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MockPJ.Models;
using MockPJ.Repositories.Interfaces;
using MockPJ.Repositories.Specifications;
using MockPJ.Services;
using MockPJ.Utilities.AutoMapperProfile;
using System.Text;

namespace MockPJ
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			builder.Services.AddDbContext<BaseContext>(opt =>
				opt.UseSqlServer(builder.Configuration.GetConnectionString("database"))
			);

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(opt =>
			{
				opt.SwaggerDoc("v1", new OpenApiInfo { Title = "Test PJ API", Version = "v1" });
				opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					In = ParameterLocation.Header,
					Description = "Please enter a valid token",
					Name = "Authorization",
					Type = SecuritySchemeType.Http,
					BearerFormat = "JWT",
					Scheme = "Bearer"
				});

				opt.AddSecurityRequirement(new OpenApiSecurityRequirement
				{
					{
						new OpenApiSecurityScheme
						{
							Reference = new OpenApiReference
							{
								Type=ReferenceType.SecurityScheme,
								Id="Bearer"
							}
						},
						new string[]{}
					}
				});
			});

			builder.Services.AddScoped<TokenService, TokenService>();
			builder.Services.AddScoped<IUserRepository, UserRepository>();
			builder.Services.AddScoped<SessionService, SessionService>();

			/*			builder.Services.AddIdentity<User, IdentityRole>(options =>
						{
							options.SignIn.RequireConfirmedAccount = false;
							options.User.RequireUniqueEmail = true;
							options.Password.RequireDigit = false;
							options.Password.RequiredLength = 6;
							options.Password.RequireNonAlphanumeric = false;
							options.Password.RequireUppercase = false;
						})
						.AddRoles<IdentityRole>()
						.AddEntityFrameworkStores<BaseContext>();*/

			builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.IncludeErrorDetails = true;
				options.TokenValidationParameters = new TokenValidationParameters()
				{
					ClockSkew = TimeSpan.Zero,
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = builder.Configuration.GetValue<string>("JwtTokenSettings:ValidIssuer"),
					ValidAudience = builder.Configuration.GetValue<string>("JwtTokenSettings:ValidAudience"),
					IssuerSigningKey = new SymmetricSecurityKey(
								Encoding.UTF8.GetBytes(builder.Configuration.GetValue<string>("JwtTokenSettings:SymmetricSecurityKey"))
						),
				};
			});

			builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();
			app.UseAuthentication();
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}

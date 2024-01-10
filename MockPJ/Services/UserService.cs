using AutoMapper;
using MockPJ.Models;
using MockPJ.Models.DTOs;
using MockPJ.Repositories.Interfaces;
using MockPJ.Utilities.CustomException;

namespace MockPJ.Services
{
	public class UserService
	{
		private readonly IUserRepository _userRepository;
		private readonly IUserRoleRepository _roleRepository;
		private readonly IMapper _mapper;

		public UserService(IUserRepository userRepository, IUserRoleRepository roleRepository, IMapper mapper)
		{
			_userRepository = userRepository;
			_roleRepository = roleRepository;
			_mapper = mapper;
		}

		public async Task<GetLandLordDetailsReturnDTO> GetLandLordDetails(int id)
		{
			var user = await _userRepository.GetLandLordDetailsAsync(x => x.UserID == id);

			return _mapper.Map<GetLandLordDetailsReturnDTO>(user);
		}

		public async Task<StaffReturnDTO> CreateStaff(CreateStaffDTO dto)
		{
			var mappedStaff = _mapper.Map<User>(dto);
			var roleStaff = await _roleRepository.GetAsync(x => x.RoleName == "Staff");
			mappedStaff.RoleID = roleStaff.RoleID;

			mappedStaff.Password = BCrypt.Net.BCrypt.HashPassword("Aa@123456");
			mappedStaff.Active = true;

			var user = await _userRepository.AddAsync(mappedStaff);

			return _mapper.Map<StaffReturnDTO>(user);
		}

		public async Task<StaffReturnDTO> AdminUpdateStaff(int id, AdminUpdateStaffDTO dto)
		{
			var staff = await _userRepository.GetAsync(x => x.UserID == id);
			if (staff == null)
			{
				throw new NotFoundException("Staff not found");
			}

			var mappedStaff = _mapper.Map<AdminUpdateStaffDTO, User>(dto, staff);
			var user = await _userRepository.UpdateAsync(mappedStaff);

			return _mapper.Map<StaffReturnDTO>(user);
		}

		public async Task<int> DeleteStaff(int id)
		{
			var staff = await _userRepository.GetAsync(x => x.UserID == id);

			if(staff == null)
			{
				throw new NotFoundException("Staff not found");
			}

			return await _userRepository.DeleteAsync(staff);
		}

		public async Task<List<StaffReturnDTO>> GetStaffsList()
		{
			var roleStaff = await _roleRepository.GetAsync(x => x.RoleName == "Staff");
			var list = await _userRepository.GetListAsync(x => x.RoleID == roleStaff.RoleID);

			return _mapper.Map<List<StaffReturnDTO>>(list);
		}
	}
}

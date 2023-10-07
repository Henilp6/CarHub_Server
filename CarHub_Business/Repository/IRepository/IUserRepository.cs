using CarHub_Business.Repository.IRepository;
using CarHub_DataAccess;
using CarHub_Models;

namespace CarHub_Business.Repository.IRepository
{
	public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<ApplicationUserDTO> Register(RegisterationRequestDTO registerationRequestDTO);
    }
}

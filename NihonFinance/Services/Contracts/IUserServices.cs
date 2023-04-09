using NihonFinance.DTOs.Users;

namespace NihonFinance.Services.Contracts
{
    public interface IUserServices
    {
        Task CreateUser(CreateUserDTO createUserDTO);

        Task<CreateUserDTO> GetUserEmail(string userEmail);
    }
}

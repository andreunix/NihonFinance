using NihonFinance.DTOs.Users;
using NihonFinance.Services.Contracts;

namespace NihonFinance.Services
{
    public class UserServices : IUserServices
    {
        public async Task CreateUser(CreateUserDTO createUserDTO)
        {
            var userReturn = await GetUserEmail(createUserDTO.UserEmail);


        }

        public Task<CreateUserDTO> GetUserEmail(string userEmail)
        {
            throw new NotImplementedException();
        }
    }
}

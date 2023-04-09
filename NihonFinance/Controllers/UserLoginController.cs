using Microsoft.AspNetCore.Mvc;
using NihonFinance.DTOs.Users;
using NihonFinance.Extensions;
using NihonFinance.Services.Contracts;

namespace NihonFinance.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserLoginController : ControllerBase
    {
        #region Properties

        private readonly IUserServices _userServices;

        #endregion Properties

        #region Constructor

        public UserLoginController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        #endregion Constructor

        [HttpPost]
        public async Task<ActionResult<CreateUserDTO>> CreateUser(
            [FromBody] CreateUserDTO modelDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState.GetErrors());

                await _userServices.CreateUser(modelDTO);

                return Ok("Batatinha");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

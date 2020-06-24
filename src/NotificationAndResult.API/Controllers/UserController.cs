using Microsoft.AspNetCore.Mvc;
using NotificationAndResult.Core.Application.Interfaces;
using NotificationAndResult.Core.Application.ViewModels;
using NotificationAndResult.Core.Utils.ResultObjects;

namespace NotificationAndResult.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost]
        public Result<UserViewModel> Create([FromBody] CreateUserViewModel userViewModel)
        {
            var userCreated = _userAppService.CreateUser(userViewModel);
            return userCreated;
        }
    }
}

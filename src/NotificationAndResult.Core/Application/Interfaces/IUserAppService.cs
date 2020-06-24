using NotificationAndResult.Core.Application.ViewModels;
using NotificationAndResult.Core.Utils.ResultObjects;

namespace NotificationAndResult.Core.Application.Interfaces
{
    public interface IUserAppService
    {
        Result<UserViewModel> CreateUser(CreateUserViewModel userViewModel);
    }
}

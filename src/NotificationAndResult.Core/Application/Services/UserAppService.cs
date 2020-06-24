using System;
using NotificationAndResult.Core.Application.Interfaces;
using NotificationAndResult.Core.Application.ViewModels;
using NotificationAndResult.Core.Domain.Entities;
using NotificationAndResult.Core.Utils.NotificationObjects;
using NotificationAndResult.Core.Utils.ResultObjects;

namespace Validations.Core.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly NotificationContext _notificationContext;

        public UserAppService(NotificationContext notificationContext)
        {
            _notificationContext = notificationContext;
        }

        public Result<UserViewModel> CreateUser(CreateUserViewModel userViewModel)
        {
            var user = new User(userViewModel.Name, userViewModel.Email, userViewModel.PhoneNumber);

            if (user.Invalid)
            {
                _notificationContext.AddNotifications(user.ValidationResult);
                return default;
            }

            // CODE TO INSERT USER IN DB HERE

            return new Result<UserViewModel>()
            {
                Succeeded = true,
                Data = new UserViewModel()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber
                }
            };
        }
    }
}

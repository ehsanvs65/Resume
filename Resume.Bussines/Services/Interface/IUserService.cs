using Resume.DAL.ViewModels.User;

namespace Resume.Bussines.Services.Interface;

public interface IUserService
{
    #region Methods

    Task<CreateUserResult> CreateAsync(CreateUserViewModel model);

    #endregion
}
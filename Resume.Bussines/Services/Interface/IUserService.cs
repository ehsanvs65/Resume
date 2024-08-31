using Resume.DAL.ViewModels.User;

namespace Resume.Bussines.Services.Interface;

public interface IUserService
{
    #region Methods

    Task<CreateUserResult> CreateAsync(CreateUserViewModel model);
    Task<EditUserViewModel> GetForEditByIdAsync(int id);
    Task<EditUserResult> UpdateAsync(EditUserViewModel model);

    #endregion
}
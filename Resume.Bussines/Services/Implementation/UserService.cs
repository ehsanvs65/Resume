using Resume.Bussines.Services.Interface;
using Resume.DAL.Models.User;
using Resume.DAL.Repositories.Interface;
using Resume.DAL.ViewModels.User;

namespace Resume.Bussines.Services.Implementation;

public class UserService:IUserService
{
    #region Filds

    private readonly IUserRepository _userRepository;

    #endregion

    #region Constructor

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    #endregion

    #region Methods

    public async Task<CreateUserResult> CreateAsync(CreateUserViewModel model)
    {
        User user = new User()
        {
            CreateDate = DateTime.Now,
            Email = model.Email,
            FirstName = model.FirstName,
            LastName = model.LastName,
            IsActive = model.IsActive,
            Mobile = model.Mobile,
            Password = model.Password
        };
        await _userRepository.InsertAsync(user);
        await _userRepository.SaveAsync();
        return CreateUserResult.Success;
    }

    #endregion
}
using Resume.DAL.Models.User;

namespace Resume.DAL.Repositories.Interface;

public interface IUserRepository
{
     #region Methods

     Task InsertAsync(User user);
     Task SaveAsync();

     #endregion

}
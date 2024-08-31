using Resume.DAL.Models.User;

namespace Resume.DAL.Repositories.Interface;

public interface IUserRepository
{
     #region Methods

     Task InsertAsync(User user);
     Task<User> GetByIdAsync(int id);
     Task SaveAsync();
     Task<bool> DuplicatedEmailAsync(int id, string email);
     Task<bool> DuplicatedMobileAsync(int id, string mobile);
     void Update(User user);
     

     #endregion

}
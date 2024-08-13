using Resume.DAL.Context;
using Resume.DAL.Models.User;
using Resume.DAL.Repositories.Interface;

namespace Resume.DAL.Repositories.Implementation;

public class UserRepository:IUserRepository
{
    #region Fields

    private readonly ResumeContext _context;

    #endregion

    #region Constructor

    public UserRepository(ResumeContext context)
    {
        _context = context;
    }

    #endregion

    #region Methods

    public async Task InsertAsync(User user)
    {
        await _context.Users.AddAsync(user);
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    #endregion
}
using ZeldaGuide.Models.User;

namespace ZeldaGuide.Services.User;
public interface IUserService
{
    Task<bool> RegisterUserAsync(UserRegister model);
    Task<UserDetail?> GetUserByIdAsync(int userId);
    
}
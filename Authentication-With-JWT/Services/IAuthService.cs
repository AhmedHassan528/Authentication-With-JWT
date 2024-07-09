using Authentication_With_JWT.Models;

namespace Authentication_With_JWT.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAsync(RegisterModel model);
    }
}

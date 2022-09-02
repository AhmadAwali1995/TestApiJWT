using TestApiJWT.Models;

namespace TestApiJWT.Services
{
    public interface IAuthService
    {
        public Task<AuthModel> RegisterAsync(RegisterModel model);
        public Task<AuthModel> GetTokenAsync(TokenRequestModel model);
        public Task<string> AddRoleAsync(RoleModel model);
    }
}

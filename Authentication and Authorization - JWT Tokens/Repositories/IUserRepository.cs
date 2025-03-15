using Authentication_and_Authorization___JWT_Tokens.Models;

namespace Authentication_and_Authorization___JWT_Tokens.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
        Task AddUser(User user);
    }
}

using PTApp.Server.Models;

namespace PTApp.Server.Repositories.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetUserByEmailAsync(string email);

    }
}

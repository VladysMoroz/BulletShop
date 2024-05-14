using Core.Entities;

namespace Core.Interfaces.Repositories
{
    public interface IUserRepository
    {
        public Task Add(User user);
        public Task<User> GetByEmail(string email);
    }
}

using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace DatabaseCatalog.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CatalogDbContext _dbContext;
        public UserRepository(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<User> GetByEmail(string email)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email) ?? throw new Exception();

            return user;
        }
    }
}

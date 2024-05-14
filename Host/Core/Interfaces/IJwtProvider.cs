using Core.Entities;

namespace Core.Interfaces
{
    public interface IJwtProvider
    {
        public string GenerateToken(User user);
    }
}

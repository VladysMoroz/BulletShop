using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace ApplicationServices.Services
{
    public class UserService : IUserService
    {
        private readonly IMyPasswordHasher _passwordHasher;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        public UserService(IMyPasswordHasher passwordHasher, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _passwordHasher = passwordHasher;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
         }
        public async Task Register(string userName, string email, string password)
        {
            var hashedPassword = _passwordHasher.Generate(password);

            var user = new User
            {
                UserName = userName,
                Email = email,
                PasswordHash = hashedPassword
            };

            await _userRepository.Add(user);
        }
        public async Task<string> Login(string email, string password)
        {
            var user = await _userRepository.GetByEmail(email);

            var result = _passwordHasher.Verify(password, user.PasswordHash);

            if(result == false)
            {
                throw new Exception("Failed to login");
            }

            var token = _jwtProvider.GenerateToken(user);

            return token;
        }
    }
}

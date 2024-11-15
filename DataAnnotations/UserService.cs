using Microsoft.AspNetCore.Identity;

namespace DataAnnotations
{
    public class UserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IPasswordHasher<User> _passwordHasher;

        public UserService(UserManager<User> userManager, IPasswordHasher<User> passwordHasher)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
        }

        public async Task CreateUserAsync(User user, string password)
        {
            // Şifreyi hash'leyelim
            user.Password = _passwordHasher.HashPassword(user, password);

            // Kullanıcıyı veritabanına ekleyelim
            await _userManager.CreateAsync(user);
        }
    }
}

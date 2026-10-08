using RaceDay.Api.Models;
using RaceDay.Api.DTOs;

namespace RaceDay.Api.Services
{
    public class UserService : IUserService
    {
        private static List<User> users = new();

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User Register(RegisterDTO dto)
        {
            User user = new User
            {
                UserId = users.Count + 1,
                FullName = dto.FirstName + " " + dto.LastName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Role = dto.Role
            };

            users.Add(user);

            return user;
        }

        public User? Login(LoginDTO dto)
        {
            var user = users.FirstOrDefault(u =>
                u.Email == dto.Email);

            if (user == null)
            {
                return null;
            }

            bool valid =
                BCrypt.Net.BCrypt.Verify(
                    dto.Password,
                    user.PasswordHash);

            return valid ? user : null;
        }
    }
} 
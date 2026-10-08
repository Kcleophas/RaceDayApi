using RaceDay.Api.Models;
using RaceDay.Api.DTOs;

namespace RaceDay.Api.Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();

        User Register(RegisterDTO dto);

        User? Login(LoginDTO dto);
    }
}
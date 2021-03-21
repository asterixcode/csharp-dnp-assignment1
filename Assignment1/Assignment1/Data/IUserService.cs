using Models;

namespace Assignment1.Data
{
    public interface IUserService
    {
        User ValidateUser(string UserName, string Password);
    }
}
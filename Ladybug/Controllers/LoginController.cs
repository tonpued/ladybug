using Ladybug.Models.User;
using Ladybug.Repository.User;
using Microsoft.AspNetCore.Mvc;

namespace Ladybug.Controllers
{
    public class LoginController
    {
        private readonly IUserRepository UserRepository;
        public LoginController(IUserRepository UserRepository) 
        {
            this.UserRepository = UserRepository;
        }
        [HttpPost("api/user")]
        public int userLogin([FromBody] UsersRequest user)
        {
            return this.UserRepository.UserLogin(user);
        }
    }
}

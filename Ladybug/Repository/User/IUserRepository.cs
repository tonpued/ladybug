using Ladybug.Models.User;

namespace Ladybug.Repository.User
{
    public interface IUserRepository
    {
        int UserLogin(UsersRequest user);
    }
}

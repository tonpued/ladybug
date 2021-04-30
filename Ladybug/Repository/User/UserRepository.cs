using Ladybug.Data;
using Ladybug.Models.User;
using System.Linq;

namespace Ladybug.Repository.User
{
    public class UserRepository : IUserRepository
    {
        private readonly LadybugContext context;
        public UserRepository(LadybugContext context)
        {
            this.context = context;
        }

        public int UserLogin(UsersRequest user)
        {
            string password = corverToPassword(user.password);
            UsersModels userlogin = this.context.User.Where(a => a.username == user.username && a.password == password).FirstOrDefault();
            int position_id = userlogin != null ? userlogin.position_id : 0;
            return position_id; 
        }

        private string corverToPassword(string pass)
        {
            char[] passUser = pass?.ToCharArray();
            return string.Join("BUG", passUser);
        }
    }
}

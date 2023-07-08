using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public interface IUserListService
    {
        Dictionary<string,object> ValidateUserLogin(string username, string password);
    }
}

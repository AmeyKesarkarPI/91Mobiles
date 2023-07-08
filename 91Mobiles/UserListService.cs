using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public class UserListService : IUserListService
    {
        public ObservableCollection<User> UserList { get; set; }

        public UserListService()
        {
            UserList = new ObservableCollection<User>()
            {
                new User() {UserID = 1, UserName = "Mohan", TypeID = 1, Password = "mohan123"},
                new User() {UserID = 2, UserName = "Rohan", TypeID = 1, Password = "rohan123"},
                new User() {UserID = 3, UserName = "Sanjana", TypeID = 1, Password = "sanjana123"},
                new User() {UserID = 4, UserName = "Admin", TypeID = 2, Password = "admin123"},
                new User() {UserID = 5, UserName = "Kailash", TypeID = 1, Password = "Lassi"},
            };
        }

        public Dictionary<string,object> ValidateUserLogin(string username, string password)
        {
            Dictionary<string, object> CommonResponse = new Dictionary<string, object>
            {
                { "IsSuccess", UserList.Where(x => x.UserName == username && x.Password == password).Any() },
                { "UserType", UserList.Where(y => y.UserName == username && y.Password == password).Select(x => x.TypeID).FirstOrDefault() }
            };

            return CommonResponse;
        }
    }
}

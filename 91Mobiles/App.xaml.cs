using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace _91Mobiles
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            MobileRegistry.Register<IMobileListService>(new MobileListService());
            MobileRegistry.Register<IUserListService>(new UserListService());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public class UserViewModel : BaseWindowViewModel
    {
        public MainViewModel MainViewModel { get; set; }

        public UserViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
        }
    }
}

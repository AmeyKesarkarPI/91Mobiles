using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public class UserViewModel : BaseWindowViewModel
    {
        public MainViewModel MainViewModel { get; set; }
        public ObservableCollection<Mobile> MobilesList { get; set; }

        public UserViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            MobilesList =  MainViewModel.MobileList;
        }
    }
}

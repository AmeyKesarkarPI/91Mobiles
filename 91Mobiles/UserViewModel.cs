using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class UserViewModel : BaseWindowViewModel
    {
        public MainViewModel MainViewModel { get; set; }
        public ObservableCollection<Mobile> MobilesList { get; set; }
        public ICommand LogoutButton { get; set; }

        public UserViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            MobilesList =  MainViewModel.MobileList;
            LogoutButton = new RelayCommand(LogoutAction);
        }

        private void LogoutAction()
        {
            MainViewModel.ActiveView = new UserLoginViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }
    }
}

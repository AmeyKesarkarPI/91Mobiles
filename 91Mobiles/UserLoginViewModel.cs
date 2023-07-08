using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace _91Mobiles
{
    public class UserLoginViewModel : BaseWindowViewModel
    {
        public MobileListService MobileListService { get; set; }
        public UserListService UserListService { get; set; }
        public ObservableCollection<Mobile> MobilesList { get; set; }
        public BaseWindowViewModel ActiveView { get; set; }
        MainViewModel MainViewModel { get; set; }
        public Dictionary<string, object> CommonResponse { get; set; }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string username { get; set; }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string password { get; set; }
        public bool IsSuccess { get; set; }
        public ICommand LoginButton { get; set; }
        public ICommand SkipButton { get; set; }

        public UserLoginViewModel(MainViewModel mainViewModel)
        {
            LoginButton = new RelayCommand(LoginAction);
            SkipButton = new RelayCommand(SkipAction);
            MainViewModel = mainViewModel;
        }

        private void SkipAction()
        {
            MainViewModel.ActiveView = new UserViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }

        private void LoginAction()
        {
            UserListService = (UserListService)MobileRegistry.GetInstance<IUserListService>();
            CommonResponse = UserListService.ValidateUserLogin(Username, Password);
            if ((bool)CommonResponse["IsSuccess"])
            {
                if ((int)CommonResponse["UserType"] == 2)
                {
                    MainViewModel.ActiveView = new AdminViewModel(MainViewModel);
                    MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
                }
                else
                {
                    MainViewModel.ActiveView = new UserViewModel(MainViewModel);
                    MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
                }
            }
            else
            {
                MessageBox.Show("Login Failed !!");
            }
        }
    }
}

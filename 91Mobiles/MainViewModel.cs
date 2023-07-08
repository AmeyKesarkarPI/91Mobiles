using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _91Mobiles
{
    public class MainViewModel : BaseWindowViewModel
    {
        public MobileListService MobileListService { get; set; }
        public UserListService UserListService { get; set; }
        public ObservableCollection<Mobile> MobilesList { get; set; }
        public BaseWindowViewModel ActiveView { get; set; }

        public string Username { get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string username { get;set; }

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

        public MainViewModel()
        {
            LoginButton = new RelayCommand(LoginAction);
            SkipButton = new RelayCommand(SkipAction);
        }

        private void SkipAction()
        {

        }

        private void LoginAction()
        {
            UserListService = (UserListService)MobileRegistry.GetInstance<IUserListService>();
            IsSuccess = UserListService.ValidateUserLogin(Username, Password);
            if (!IsSuccess)
            {
                if
            }else
            {
                MessageBox.Show("Login Successfull :)");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class AdminViewModel : BaseWindowViewModel
    {
        public ICommand ViewProductsButton { get; set; }
        public ICommand AddProductsButton { get; set;}
        public ICommand LogoutButton { get; set;}

        public MainViewModel MainViewModel { get; set; }

        public AdminViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            ViewProductsButton = new RelayCommand(ViewProductsAction);
            AddProductsButton = new RelayCommand(AddProductsAction);
            LogoutButton = new RelayCommand(LogoutAction);
        }

        private void LogoutAction()
        {
            MainViewModel.ActiveView = new UserLoginViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }

        public void AddProductsAction()
        {
            MainViewModel.ActiveView = new AddProductsViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }

        public void ViewProductsAction()
        {
            MainViewModel.ActiveView = new ViewAllProductsViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }
    }
}

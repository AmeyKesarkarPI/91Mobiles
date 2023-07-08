using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class ViewAllProductsViewModel : BaseWindowViewModel
    {
        public MainViewModel MainViewModel { get; set; }
        public ObservableCollection<Mobile> MobileList { get; set; }   
        public ICommand BackButton { get; set; }
        public ViewAllProductsViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            MobileList = MainViewModel.MobileList;
            OnPropertyChanged(nameof(MobileList));
            BackButton = new RelayCommand(BackAction);
        }

        private void BackAction()
        {
            MainViewModel.ActiveView = new AdminViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class Mobile
    {
        public MainViewModel MainViewModel { get; set; }
        public ICommand DeleteProductButton { get; set; }

        public int MobileID { get; set; }
        public string ModelName { get;set ; }
        public string BrandName { get;set; }
        public long Price { get; set; }
        public string ImageUri { get; set; }
        public ObservableCollection<Specification> Specifications { get; set; }

        public Mobile(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            DeleteProductButton = new RelayCommand(DeleteProductAction);
        }

        public void DeleteProductAction()
        {
            MainViewModel.MobileList.Remove(this);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.MobileList));
        }
    }
}

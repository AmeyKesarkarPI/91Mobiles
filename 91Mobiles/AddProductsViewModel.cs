using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class AddProductsViewModel : BaseWindowViewModel
    {
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string Price { get; set; }
        public string ImageUri { get; set; }
        public Dictionary<string,string> Specifications { get; set; }
        
        public ICommand BrowseButton { get; set; }
        public MainViewModel MainViewModel { get; set; }
        public AddProductsViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            BrowseButton = new RelayCommand(BrowseAction);
        }

        public void BrowseAction()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Images files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == true)
            {
                ImageUri = openFileDialog.FileName;
            }
        }
    }
}

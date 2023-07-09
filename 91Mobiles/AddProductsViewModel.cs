using Microsoft.Win32;
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
    public class AddProductsViewModel : BaseWindowViewModel
    {
        public string ModelName { get; set; }
        public string BrandName { get; set; }
        public string Price { get; set; }
        public string ImageUri { get; set; }
        public ObservableCollection<Specification> SpecificationsCollection
        { get; set; } = new ObservableCollection<Specification>();
        public string Key { get; set; }
        public string Value { get; set; }

        public ICommand BrowseButton { get; set; }
        public ICommand AddSpecificationButton { get; set; }
        public ICommand SaveButton { get; set; }
        public ICommand BackButton { get; set; }

        public MainViewModel MainViewModel { get; set; }
        public AddProductsViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            BrowseButton = new RelayCommand(BrowseAction);
            AddSpecificationButton = new RelayCommand(AddSpecificationAction);
            SaveButton = new RelayCommand(SaveAction);
            BackButton = new RelayCommand(BackAction);
        }

        private void BackAction()
        {
            MainViewModel.ActiveView = new AdminViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }

        private void SaveAction()
        {
            SpecificationsCollection.Add(
                new Specification(this)
                {
                    ID = SpecificationsCollection.Count(),
                    Key = Key,
                    Value = Value
                });

            MainViewModel.MobileListService.AddNewMobile(new Mobile(MainViewModel)
            {
                MobileID = MainViewModel.MobileList.Count,
                ModelName = ModelName,
                BrandName = BrandName,
                Price = int.Parse(Price),
                Specifications = SpecificationsCollection,
                ImageUri = ImageUri,
            });

            MainViewModel.OnPropertyChanged(nameof(MainViewModel.MobileList));
            MessageBox.Show("Mobile Addedd Successfully!!");

            MainViewModel.ActiveView = new AddProductsViewModel(MainViewModel);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.ActiveView));
        }

        private void AddSpecificationAction()
        {
            SpecificationsCollection.Add(
                new Specification(this)
                {
                    ID = SpecificationsCollection.Count(),
                });
            OnPropertyChanged(nameof(SpecificationsCollection));
        }

        public void BrowseAction()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Images files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                ImageUri = openFileDialog.FileName;
            }
        }
    }
}

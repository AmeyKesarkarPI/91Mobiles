using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _91Mobiles
{
    public class Mobile : INotifyPropertyChanged
    {
        public MainViewModel MainViewModel { get; set; }

        public Visibility StackVisibility
        {
            get
            {
                return stackVisibility;
            }
            set
            {
                stackVisibility = value;
            }
        }

        private Visibility stackVisibility { get; set; } = Visibility.Visible;


        public Visibility DetailsStackVisibility
        {
            get
            {
                return detailsStackVisibility;
            }
            set
            {
                detailsStackVisibility = value;
            }
        }

        private Visibility detailsStackVisibility { get; set; } = Visibility.Collapsed;

        public string ButtonContent
        {
            get
            {
                return buttonContent;
            }
            set
            {
                buttonContent = value;
            }
        }
        public string buttonContent { get; set; } = "View Details";

        public ICommand DeleteProductButton { get; set; }
        public ICommand ViewDetailsButton { get; set; }
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
            ViewDetailsButton = new RelayCommand(ViewDetailsAction);
        }

        private void ViewDetailsAction()
        {
            if(StackVisibility == Visibility.Collapsed)
            {
                DetailsStackVisibility = Visibility.Collapsed;
                StackVisibility = Visibility.Visible;
                ButtonContent = "View Details";
            }
            else
            {
                DetailsStackVisibility = Visibility.Visible;
                StackVisibility = Visibility.Collapsed;
                ButtonContent = "Back";
            }

            OnPropertyChanged(nameof(DetailsStackVisibility));
            OnPropertyChanged(nameof(StackVisibility));
            OnPropertyChanged(nameof(ButtonContent));
        }

        public void DeleteProductAction()
        {
            MainViewModel.MobileList.Remove(this);
            MainViewModel.OnPropertyChanged(nameof(MainViewModel.MobileList));
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _91Mobiles
{
    public class Specification
    {
        public AddProductsViewModel AddProductsViewModel { get; set; }
        public ICommand DeleteSpecificationButton { get; set; }

        public int ID { get; set; }
        public string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }
        private string key { get; set; }

        public string Value
        {
            get
            {
                return values;
            }
            set
            {
                values = value;
            }
        }
        private string values { get; set; }

        public Specification(AddProductsViewModel addProductsViewModel)
        {
            AddProductsViewModel = addProductsViewModel;
            DeleteSpecificationButton = new RelayCommand(DeleteSpecificationAction);
        }

        private void DeleteSpecificationAction()
        {
            AddProductsViewModel.SpecificationsCollection.Remove(this);

            AddProductsViewModel.OnPropertyChanged(nameof(AddProductsViewModel.SpecificationsCollection));
        }
    }
}

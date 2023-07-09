using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public class MobileListService : IMobileListService
    {
        public ObservableCollection<Mobile> MobilesList { get; set; }

        public ObservableCollection<Mobile> GetMobileList(MainViewModel mainViewModel)
        {
            MobilesList = new ObservableCollection<Mobile>()
            {
                new Mobile(mainViewModel){ MobileID = 1, BrandName = "IPhone", ModelName = "13", Price = 80000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/iphone13.jpg", Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                } },
                new Mobile(mainViewModel){ MobileID = 2, BrandName = "IPhone", ModelName = "14", Price = 100000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/iphone14.png" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
                new Mobile(mainViewModel){ MobileID = 3, BrandName = "Samsung", ModelName = "A51", Price = 25000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/samsungA51.jpg" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
                new Mobile(mainViewModel){ MobileID = 4, BrandName = "Samsung", ModelName = "M31", Price = 19000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/samsungM31.jpg" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
                new Mobile(mainViewModel){ MobileID = 5, BrandName = "Vivo", ModelName = "S1 pro", Price = 15000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/vivoS1pro.png" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
                new Mobile(mainViewModel){ MobileID = 6, BrandName = "Vivo", ModelName = "V20", Price = 20000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/vivoV20.png" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
                new Mobile(mainViewModel){ MobileID = 7, BrandName = "1+", ModelName = "10 pro", Price = 40000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/oneplus10pro.jpg" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
                new Mobile(mainViewModel){ MobileID = 8, BrandName = "1+", ModelName = "Nord CE 3", Price = 100000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/oneplusNordCE3.jpg" , Specifications  =  new ObservableCollection<Specification>()
                {
                    new Specification(null) { Key = "Ram", Value = "8gb"},
                    new Specification(null) { Key = "External Storage", Value = "256gb"},
                    new Specification(null) { Key = "Color", Value = "Midnight Gray"},
                }},
            };

            return MobilesList;
        }

        public void AddNewMobile(Mobile mobile)
        {
            MobilesList.Add(mobile);
        }
    }
}

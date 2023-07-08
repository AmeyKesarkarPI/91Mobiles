﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public class MobileListService : IMobileListService
    {
        public ObservableCollection<Mobile> GetMobileList()
        {
            ObservableCollection<Mobile> MobilesList = new ObservableCollection<Mobile>()
            {
                new Mobile(){ MobileID = 1, BrandName = "IPhone", ModelName = "13", Price = 80000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/iphone13.jpg"},
                new Mobile(){ MobileID = 2, BrandName = "IPhone", ModelName = "14", Price = 100000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/iphone14.png"},
                new Mobile(){ MobileID = 3, BrandName = "Samsung", ModelName = "A51", Price = 25000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/samsungA51.jpg"},
                new Mobile(){ MobileID = 4, BrandName = "Samsung", ModelName = "M31", Price = 19000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/samsungM31.jpg"},
                new Mobile(){ MobileID = 5, BrandName = "Vivo", ModelName = "S1 pro", Price = 15000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/vivoS1pro.png"},
                new Mobile(){ MobileID = 6, BrandName = "Vivo", ModelName = "V20", Price = 20000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/vivoV20.png"},
                new Mobile(){ MobileID = 7, BrandName = "1+", ModelName = "10 pro", Price = 40000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/oneplus10pro.jpg"},
                new Mobile(){ MobileID = 8, BrandName = "1+", ModelName = "Nord CE 3", Price = 100000, ImageUri = "C:/Users/Amey.Kesarkar/source/repos/91Mobiles/91Mobiles/images/oneplusNordCE3.jpg"},
            };

            return MobilesList;
        }
    }
}
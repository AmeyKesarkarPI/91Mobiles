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
        public BaseWindowViewModel ActiveView { get; set; }
        public MobileListService MobileListService { get; set; }
        public ObservableCollection<Mobile> MobileList { get; set; }

        public MainViewModel()
        {
            ActiveView = new UserLoginViewModel(this);
            MobileListService = (MobileListService)MobileRegistry.GetInstance<IMobileListService>();
            MobileList = MobileListService.GetMobileList(this);

            OnPropertyChanged(nameof(MobileList));
        }
    }
}

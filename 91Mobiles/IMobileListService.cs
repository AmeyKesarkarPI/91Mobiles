using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public interface IMobileListService
    {
        ObservableCollection<Mobile> GetMobileList();
    }
}

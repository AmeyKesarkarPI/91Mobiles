using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _91Mobiles
{
    public static class MobileRegistry
    {
        static Dictionary<Type, object> Registry = new Dictionary<Type, object>();

        public static void Register<T>(T instance)
        {
            Registry.Add(typeof(T), instance);
        }

        public static T GetInstance<T>()
        {
            return (T)Registry[typeof(T)];
        } 
    }
}

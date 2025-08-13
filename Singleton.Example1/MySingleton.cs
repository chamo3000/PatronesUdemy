using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Example1
{
    public class MySingleton
    {
        private static MySingleton _instance;

        private MySingleton()
        {
                
        }

        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MySingleton();
            }
            return _instance;
        }
    }
}

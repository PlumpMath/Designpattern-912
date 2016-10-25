using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配模式的经典案例__电压
{
    class ChConnect : ICH
    {
        public void connect()
        {
            Console.WriteLine("220V");
        }
    }
}

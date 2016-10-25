using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配模式的经典案例__电压
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IChange change = new Adapter(new ChConnect());

            change.change();

            Console.ReadKey();        
        }
    }
}

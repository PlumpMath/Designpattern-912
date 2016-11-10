using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new BOC("中国银行");
            bank.IMoney = new Current();
            bank.Behavior();

            Console.ReadKey();
        }
    }
}

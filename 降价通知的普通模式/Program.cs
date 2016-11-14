using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 降价通知的普通模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小王");
            Commodity commodity = new Commodity();
            commodity.name = "手机";
            commodity.price = 10000;
            commodity.person = person;
            commodity.CutPrice();
            Console.ReadKey();
        }
    }
}

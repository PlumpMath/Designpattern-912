using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 降价通知的观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("小王");
            Commodity commodity = new Commodity("手机", 100.8);
            commodity.NotifyEvent +=new Commodity.NotifyEventHandler(person.Receive);
            commodity.Send();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime milestone;
            int maxCallTimes= 100000000;

            // 第一次调用SampleSingleton1的Counter方法
            Console.WriteLine("第一次调用SampleSingleton1的Counter方法");
            SampleSingleton1.singleton.Counter();

            // 计算10000次调用的耗费时间
            milestone = DateTime.Now;
            for (int i = 0; i < maxCallTimes; i++)
            {
                SampleSingleton1.singleton.Counter();
            }
            Console.WriteLine(maxCallTimes.ToString() + "次调用执行时间为：" + ((TimeSpan)(DateTime.Now - milestone)).TotalMilliseconds.ToString());
            Console.WriteLine("");


            // 第一次调用SampleSingleton2的Counter方法
            Console.WriteLine("第一次调用SampleSingleton2的Counter方法");
            SampleSingleton2.Singleton.Couter();

            // 计算10000次调用的耗费时间
            milestone = DateTime.Now;
            for (int i = 0; i < maxCallTimes; i++)
            {
                SampleSingleton2.Singleton.Couter();
            }
            Console.WriteLine(maxCallTimes.ToString() + "次调用执行时间为：" + ((TimeSpan)(DateTime.Now - milestone)).TotalMilliseconds.ToString());

            string str = Console.ReadLine();
        }
    }
}

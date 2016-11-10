using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程计数
{
    /// <summary>
    /// 功能：创建一个多线程计数的类
    /// 编写：王统周
    /// 日期：2016/10/27
    /// </summary>
    public class CountMutilThread
    {
        public static void DoSomeWork()
        {
            ///每次调用显示的字符串
            string results = "";

            //创建一个singleton的实例
            CountSigleton myCounter = CountSigleton.Instance();

            for (int i = 0; i < 5; i++)
            {
                myCounter.Add();
                results += "线程";
                results += Thread.CurrentThread.Name.ToString() + "——〉";

                results += Thread.CurrentThread.ManagedThreadId;
                results += "当前的计数：";
                results += myCounter.GetCounter().ToString();
                results += "\n";
              
                Console.WriteLine(results);
              
                ///清空显示字符串
                results = "";
            }
        }

        public void StartMain()
        {
            Thread tread0 = Thread.CurrentThread;

            tread0.Name = "tread0";

            Thread thread1 = new Thread(new ThreadStart(DoSomeWork));

            thread1.Name = "Thread 1";
            
          Thread thread2 = new Thread(new ThreadStart(DoSomeWork));
          
          thread2.Name = "Thread 2";
          
          Thread thread3 = new Thread(new ThreadStart(DoSomeWork));
          
          thread3.Name = "Thread 3";
          
          thread1.Start();
          
          thread2.Start();
          
          thread3.Start();
          
            ///线程0也只执行和其他线程相同的工作
          DoSomeWork();
        }
    }
}

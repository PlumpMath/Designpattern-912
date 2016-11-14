using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 利用C#的特性单例模式
    /// </summary>
    public sealed  class SampleSingleton1
    {
        private int m_Counter = 0;
        private SampleSingleton1()
        {
            Console.WriteLine("初始化SampleSingle1");
        }

        public static readonly SampleSingleton1 singleton = new SampleSingleton1();
        /// <summary>
        /// 调用次数计数器
        /// </summary>
        public void Counter()
        {
            m_Counter++;
        }
    }
}

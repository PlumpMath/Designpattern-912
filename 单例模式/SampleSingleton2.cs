using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    /// <summary>
    /// 线程安全的单例模式
    /// </summary>
    public  class SampleSingleton2
    {
        private static volatile SampleSingleton2 m_Instance = null;
        private int m_Counter = 0;
        private SampleSingleton2()
        {
            Console.WriteLine("初始化SampleSingleton2.");
        }
        public static SampleSingleton2 Singleton
        {
            get
            {
                if (m_Instance == null)
                {
                    lock (typeof(SampleSingleton2))
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = new SampleSingleton2();
                        }
                    }
                }
                return m_Instance;
            }
        }
        /// <summary>
        /// 调用计数器
        /// </summary>
        public void Couter()
        {
            m_Counter++;
        }
    }
}

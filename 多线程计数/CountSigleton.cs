using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 多线程计数
{
    /// <summary>
    /// 功能：简单计数器的单例设计
    /// 编写：wtz
    /// 时间：2016/10/27 10:31
    /// </summary>
    public class CountSigleton
    {
        /// <summary>
        /// 存储唯一实例
        /// </summary>
        static readonly CountSigleton uniCounter = new CountSigleton();
        //存储计数值
        private int totNum = 0;

        private CountSigleton()
        {
            ///线程休息2000毫秒
            //Thread.Sleep(2000);
        }

        static public CountSigleton Instance()
        {
            return uniCounter;
        }
        //计数器++
        public void Add()
        {
            totNum++;
        }
        //获取计数值
        public int GetCounter()
        {
            return totNum;
        }

    }
}

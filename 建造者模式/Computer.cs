using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 电脑组合集合
        /// </summary>
        private List<string> parts = new List<string>();
        //把单件添加到电脑组件集合中
        public void Add(string part)
        {
            parts.Add(part);
        }

        
        public void Show()
        {
            Console.WriteLine("电脑开始组装了");
            foreach (string part in parts)
            {
                Console.WriteLine("组件"+part+"已组装好");
            }
            Console.WriteLine("电脑组装好了");
        }
    }
}

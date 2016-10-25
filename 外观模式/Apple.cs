using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Apple : IBase
    {
        //获取苹果的名字
        public void GetName()
        {
            Console.WriteLine("我是苹果");
        }
        //获取苹果的质量
        public void GetWeight()
        {
            Console.WriteLine("我是苹果的质量");
        }
        //苹果的产地
        //这一块分别是不同方向扩展，假设是不同水果所特有的方式
        public void GetAddress()
        {
            Console.WriteLine("我的产地是山西");
        }

    }
}

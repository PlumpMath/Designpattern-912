using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Banana : IBase
    {
        //名字
        public void GetName()
        {
            Console.WriteLine("我是香蕉");
        }
        //质量
        public void GetWeight()
        {
            Console.WriteLine("我是香蕉的质量");
        }
        //颜色
        //这一块分别是不同方向扩展，假设是不同水果所特有的方式
        public void GetColor()
        {
            Console.WriteLine("我是香蕉的颜色");
        }
    }
}

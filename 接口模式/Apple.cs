using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口模式
{
    class Apple : IName
    {
        public void Name()
        {
            Console.WriteLine("我的名字是苹果");
        }
    }
}

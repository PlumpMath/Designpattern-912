using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 无工厂模式下的买水果
{
    public class Apple : Fruit
    {
        public override void Eat()
        {
            Console.WriteLine("我吃苹果");
        }
    }
}

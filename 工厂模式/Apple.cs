using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 吃水果简单工厂模式
{
    public class Apple : Fruit
    {
        public override void Eat()
        {
            Console.WriteLine("吃苹果");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 无工厂模式下的买水果
{
    class Program
    {
        static void Main(string[] args)
        {
            //当出现直接new的时候我们就应该考虑是否使用工厂模式
            //这里违反oo的原则，我们需要将改变的封装起来
            //当然下一步我们先进行简单工厂的例子
            Fruit fruit = new Apple();
            fruit.Eat();

            Fruit fruit2 = new Orange();
            fruit2.Eat();

            Console.ReadKey();

        }
    }
}

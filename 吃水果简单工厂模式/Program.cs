using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 吃水果简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //简单工厂将变化的水果封装到工厂里面使用不同的类型创建不同的对象将我们对水果的依赖变成间接的，使得对象之间的耦合度降低，但是创建对象的工厂里面，每增加一种水果就需要增加一种判断，这就是简单工厂的缺点；
            Fruit fruit = SimpleFactoryFruit.CreateFactory(FruitEnum.Apple);
            fruit.Eat();
            Fruit fruit2 = SimpleFactoryFruit.CreateFactory(FruitEnum.Orange);
            fruit2.Eat();
            Console.ReadKey();
        }
    }
}

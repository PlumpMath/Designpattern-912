using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 吃水果简单工厂模式;

namespace 工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //工厂模式解决了简单工厂模式需要更改代码的问题
            //是不是这样就结束了尼，我们的程序的扩展性也好了各种都好了那还需要更改什么尼，假如我们又增加一种水果罐头，这样我们工厂模式就不适用了，那么又该怎么养去设计尼，接下来请听下回分解--抽象工厂
            CreateFruitFactory createApple = new CreateAppleFactory();
            Fruit apple = createApple.CreateFruit();
            apple.Eat();

            CreateFruitFactory createOrage = new CreateOrangeFruit();
            Fruit orange = createOrage.CreateFruit();
            orange.Eat();
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式
{
    class Program
    {
        /// <summary>
        /// 调用
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();

            director.Construct(b1);

            Computer computer = b1.GetComputer();
            computer.Show();

            Console.ReadKey();
        }
    }
}

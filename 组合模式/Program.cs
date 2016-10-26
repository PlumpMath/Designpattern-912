using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Manger manager = new Manger("经理");
            manager.AddPosition(new Employee("经理助理"));
            manager.AddPosition(new Employee("经理秘书"));

            Manger derp = new Manger("技术经理");
            derp.AddPosition(new Employee("程序员"));

            manager.AddPosition(derp);

            manager.DisplayPostion(1);
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口模式
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IName iName = new Apple();

            iName.Name();

            Console.ReadKey();
        }
    }
}

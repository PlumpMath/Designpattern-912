using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Friend();

            person.BuyProduct();

            Console.ReadKey();
        }
    }
}

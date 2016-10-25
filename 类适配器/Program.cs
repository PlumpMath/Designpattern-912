using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类适配器
{
    class Program
    {
        static void Main(string[] args)
        {

            ILogTarget dbLog = new DatabaseAdapter();

            dbLog.Write();

            ILogTarget fileLog = new FileLogAdapter();

            fileLog.Write();

            Console.ReadKey();
        }
    }
}

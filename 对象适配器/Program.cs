using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 类适配器;

namespace 对象适配器
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogTarget dbLog = new LogAdapter(new DatabaseLog());

            dbLog.Write();

            ILogTarget fileLog = new LogAdapter(new FileLog());

            fileLog.Write();

            Console.ReadKey();

        }
    }
}

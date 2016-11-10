using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class Regular : IMoney
    {
        public override void Save(string bankName)
        {
            Console.WriteLine(bankName+"定期");
        }
    }
}

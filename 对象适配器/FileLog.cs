using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类适配器
{
    public class FileLog : LogAdaptee
    {
        public override void WriteLog()
        {
            Console.WriteLine("我是把文件里面写的");
        }
    }
}

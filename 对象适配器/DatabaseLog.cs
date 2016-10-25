using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类适配器
{
    public class DatabaseLog : LogAdaptee
    {
        public override void WriteLog()
        {
            Console.WriteLine("我把数据库里面写。。。");
        }
    }
}

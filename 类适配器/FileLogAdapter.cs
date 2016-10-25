using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类适配器
{
    class FileLogAdapter : FileLog, ILogTarget
    {
        public void Write()
        {
            this.WriteLog();
        }
    }
}

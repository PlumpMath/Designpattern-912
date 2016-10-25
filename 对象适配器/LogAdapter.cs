using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 类适配器;

namespace 对象适配器
{
    class LogAdapter : ILogTarget
    {
        private LogAdaptee _adaptee;
        public LogAdapter(LogAdaptee adaptee)
        {
            this._adaptee = adaptee;
        }
        public void Write()
        {
            _adaptee.WriteLog();
        }
    }
}

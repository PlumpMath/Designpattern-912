using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public abstract  class IMoney
    {
        public abstract void Save(string bankName);
    }
}

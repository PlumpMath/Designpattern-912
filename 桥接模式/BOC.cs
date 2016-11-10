using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    class BOC : Bank
    {
        public BOC(string bank) : base(bank)
        {
        }

        public override void Behavior()
        {
            base.Behavior();
        }
    }
}

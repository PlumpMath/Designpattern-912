using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 桥接模式
{
    public abstract class Bank
    {
        private IMoney money;

        private string _bank;
        public IMoney IMoney { set { money = value; } }

        public Bank(string bank)
        {
            _bank = bank;
        }

        public virtual void Behavior()
        {
              money.Save(_bank);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配模式的经典案例__电压
{
    class Adapter : IChange
    {
        
        private ChConnect _chConnect;
        public Adapter(ChConnect chConnect)
        {
            this._chConnect = chConnect;
        }

        public void change()
        {
            _chConnect.connect();
        }
    }
}

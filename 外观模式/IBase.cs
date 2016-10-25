using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    interface IBase
    {
        //所有水果的公共方法这块我们将他看作接口，定义所有公用的方法在里面
        //名字
        void GetName();
        //质量
        void GetWeight();

    }
}

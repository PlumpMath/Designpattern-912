using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    interface IFruitFacade
    {
        Apple apple { get; }

        Banana banana { get; }
    }
}

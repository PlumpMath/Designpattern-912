using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class FruitFacade : IFruitFacade
    {
        public Apple apple
        {
            get
            {
                return new Apple();
            }
        }

        public Banana banana
        {
            get
            {
                return new Banana();
            }
        }
    }
}

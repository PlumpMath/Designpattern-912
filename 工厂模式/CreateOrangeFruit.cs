using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 吃水果简单工厂模式;

namespace 工厂模式
{
    public class CreateOrangeFruit : CreateFruitFactory
    {
        public override Fruit CreateFruit()
        {
            return new Orange();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 吃水果简单工厂模式;

namespace 工厂模式
{
    //抽象出创建水果的工厂类，将创建真正实例的推到子类上
    //这样就不存在简单工厂的缺点，每次只需要子类增加就可以不需要在原来代码上做更改
    public abstract class CreateFruitFactory
    {
        public abstract Fruit CreateFruit();
    }
}

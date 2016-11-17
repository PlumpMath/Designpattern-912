using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 吃水果简单工厂模式
{
    /// <summary>
    /// 创建具体实例的简单工厂
    /// 当然明智的大家又会发现下面也都new，假如说我们增加一个类的情况下又要修改代码，好吧我们这么懒惰这不是我们干的事，那就引出我们下一位优秀的设计师那就是工厂设计师；
    /// </summary>
    public class SimpleFactoryFruit
    {
        public static Fruit CreateFactory(FruitEnum friutEnum)
        {
            switch (friutEnum)
            {
                case FruitEnum.Apple:
                    return new Apple();
                case FruitEnum.Orange:
                    return new Orange();
                default:
                    throw new Exception("暂时没有你想吃的水果");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 降价通知的观察者模式
{
    /// <summary>
    /// 通知的人的类
    /// 11-14 wtz
    /// </summary>
    public class Person
    {

        private string _name;
        public Person(string name)
        {
            this._name = name;
        }

        public void Receive(object obj)
        {
            if (obj is Commodity)
            {
                Commodity commodity = (Commodity)obj;
                Console.WriteLine(this._name + "收到了" + commodity.name + "的降价通知邮件现在价格为" + commodity.price);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 降价通知的普通模式
{
    public class Person
    {
        private string _name;
        public Person(string name)
        {
            this._name = name;
        }
        public void ReceiveMail(Commodity commodity)
        {
            Console.WriteLine(this._name+"收到了"+commodity.name+"的降价通知邮件现在价格为"+commodity.price);
        }
    }
}

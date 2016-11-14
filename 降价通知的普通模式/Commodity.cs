using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 降价通知的普通模式
{
    public class Commodity
    {
        private Person _person;
        private double _price;
        private string _name;

        public void CutPrice()
        {
            _person.ReceiveMail(this);
        }

        public Person person
        {
            get { return _person; }
            set { _person = value; }
        }
        public double price
        {
            get { return _price; }
            set
            { _price = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}

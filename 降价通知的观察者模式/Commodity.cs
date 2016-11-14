using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 降价通知的观察者模式
{
    /// <summary>
    /// 商品类
    /// 11-14 wtz编写
    /// </summary>
    public class Commodity
    {
        /// <summary>
        /// 与Person类解藕，不需要再借助接口的形式进行业务之间的解耦
        /// </summary>
        /// <param name="sender"></param>
        public delegate void NotifyEventHandler(object sender);

        public NotifyEventHandler NotifyEvent;

        private string _name;

        private double _price;

        public Commodity(string name,double price)
        {
            this._name = name;
            this._price = price;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double price
        {
            get { return _price; }
            set { _price = value; }
        }

        public void Send()
        {
            if (NotifyEvent != null)
            {
                NotifyEvent(this);
            }

        }
    }
}

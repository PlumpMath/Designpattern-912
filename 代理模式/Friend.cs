using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 代理模式
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class Friend : Person
    {
        RealBuyPerson realBuy;
        public override void BuyProduct()
        {
            Console.WriteLine("通过代理类实现访真正得主题方法");
            if (realBuy == null)
            {
                realBuy = new RealBuyPerson();
            }
            this.PerBuyProduct();
            //调用真实类得方法
            realBuy.BuyProduct();
            this.PostBuyProduct();
        }
        /// <summary>
        /// 买完东西代理类得分类
        /// </summary>
        private void PostBuyProduct()
        {
            Console.WriteLine("终于买完了，现在要对东西分一下，相机是张三的；Iphone是李四的..........");
        }
        /// <summary>
        /// 代理类买东西得操作
        /// </summary>
        private void PerBuyProduct()
        {
            Console.WriteLine("我怕弄糊涂了，需要列一张清单，张三：要带相机，李四：要带Iphone...........");
        }
    }
}

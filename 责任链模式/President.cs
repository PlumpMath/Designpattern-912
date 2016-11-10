using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    //总经理
    public class President : Approver
    {
        public President(string name) : base(name)
        {
        }

        public override void ProcessRequest(PurchaseRequest purchaseRequset)
        {
            if (purchaseRequset.Amount < 100000)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, 
                    purchaseRequset.ProductName);
            }
            else
            {
                Console.WriteLine("我们需要组织会议");
            }
        }
    }
}

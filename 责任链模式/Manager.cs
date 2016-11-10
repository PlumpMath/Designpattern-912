using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    //
    public class Manager : Approver
    {
        public Manager(string name) : base(name)
        {

        }

        public override void ProcessRequest(PurchaseRequest purchaseRequset)
        {
            if (purchaseRequset.Amount < 10000)
            {
                Console.WriteLine("{0}-{1} approved the request of purshing {2}", this, Name, purchaseRequset.ProductName);
            }
            else if(NextApprover!=null)
            {
                NextApprover.ProcessRequest(purchaseRequset);
            }
        }
    }
}

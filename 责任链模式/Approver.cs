using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    //审批人。
    public abstract class Approver
    {
        
        public Approver NextApprover { get; set; }

        public string Name { get; set; }

        public Approver(string name)
        {
            Name = name;
        }

        public abstract void ProcessRequest(PurchaseRequest purchaseRequset);

    }
}

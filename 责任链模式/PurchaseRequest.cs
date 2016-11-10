﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 责任链模式
{
    //采购请求
    public class PurchaseRequest
    {
        //金额
        public double Amount { get; set; }
        //产品名字
        public string ProductName { get; set; }

        public PurchaseRequest(double amount,string productName)
        {
            Amount = amount;
            ProductName = productName;
        }
    }
}

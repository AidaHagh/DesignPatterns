using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern.Ex
{
    public class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.Price < 6000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchaseOrder.RequestNumber);

            }
            else
            {
                Console.WriteLine("purchase request #{0} requires an executive meeting",
                    purchaseOrder.RequestNumber);
            }
        }
    }
}
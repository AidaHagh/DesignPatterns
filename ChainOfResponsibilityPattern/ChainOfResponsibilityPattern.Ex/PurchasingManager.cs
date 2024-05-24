using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern.Ex
{
    public class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchaseOrder)
        {
            if (purchaseOrder.Price <= 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchaseOrder.RequestNumber);
      
            }
            else if (Supervisor != null)
            {
                Supervisor.ProcessRequest(purchaseOrder);
            }
        }
    }
}
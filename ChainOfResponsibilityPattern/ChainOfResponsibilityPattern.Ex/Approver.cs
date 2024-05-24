using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibilityPattern.Ex
{
    //تصویب کننده
    public abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor (Approver supervisor)
        {
            Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchaseOrder);
       
    }
}
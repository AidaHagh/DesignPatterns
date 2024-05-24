
namespace ChainOfResponsibilityPattern.Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the chain links
            Approver yasin_HeadChef = new HeadChef();
            Approver mohammad_PurchasingManager = new PurchasingManager();
            Approver ali_GeneralManager = new GeneralManager();

            //create the chain
            yasin_HeadChef.SetSupervisor(mohammad_PurchasingManager);
            mohammad_PurchasingManager.SetSupervisor(ali_GeneralManager);

            //Generate and process purchase request
            PurchaseOrder order = new PurchaseOrder(1, 20, 500, "spices");
            yasin_HeadChef.ProcessRequest(order);

            order = new PurchaseOrder(2, 100, 2400, "chees");
            yasin_HeadChef.ProcessRequest(order);

            order = new PurchaseOrder(3, 500, 5400, "beef");
            yasin_HeadChef.ProcessRequest(order);

            order = new PurchaseOrder(4, 3, 7400, "ovens");
            yasin_HeadChef.ProcessRequest(order);
        }
    }
}
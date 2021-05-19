using System;
using StoreModels;
using BusLog;
namespace StoreUI
{
    public class ViewOrderC : IOpening
    {
        private IBusLog _BusLog;
        private IOpening menu1;
        
        Validations _validate;
        public ViewOrderC(IBusLog BusLog, Validations validate)
        {
                _BusLog = BusLog;
                _validate = validate;
        }

        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("What would you like to do Customer?");
                Console.WriteLine("[0] View Order");
                Console.WriteLine("[1] Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                case "0":
                    int orderids = FindOrder();
                    Order searchOrder = _BusLog.GetOrder3(orderids);
                    Storefront searchStorefront = _BusLog.GetStorefront3(searchOrder.Storefrontsss);
                    Console.WriteLine($"Order Number: {searchOrder.ID}\n Total: {searchOrder.Total}\n Location: {searchStorefront.Town}");
                    break;
            
                case "1":
                    repeat = false;
                    break;
                
                
                default:
                    Console.WriteLine("Please Insert valid option");
                    break;
                }
            }while(repeat);
            }



            public int FindOrder()
            {
            int pin;

            bool repeatss = true;
            do
            {
            
            pin = _validate.ValidateInt("Please enter Order number: ");
            //CREATE A DO WHILE LOOP HERE
            repeatss= !(_BusLog.GetOrderT(pin));
            }while(repeatss);
            Console.WriteLine($"{pin}");
            return pin;        
            
            }    






    }
}

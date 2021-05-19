using System;
using StoreModels;
using BusLog;
namespace StoreUI
{
    public class ExistingCustomerMenu : IOpening
    {

        private IOpening menu1;
        

    
        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("What would you like to do Customer?");
                Console.WriteLine("[0] Place Order");
                Console.WriteLine("[1] View Orders");
                Console.WriteLine("[2] View Inventory");
                Console.WriteLine("[3] Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                case "0":
                    menu1 = Opening.GetMenu("PlaceOrder");
                    menu1.Start();
                    break;
                case "1":
                    menu1 = Opening.GetMenu("ViewOrder");
                    menu1.Start();
                    break;
                case "2":
                    menu1 = Opening.GetMenu("ViewInventoryC");
                    menu1.Start();
                    break;
                case "3":
                    Console.WriteLine("Thank you! Have a good day!");
                    repeat = false;
                    break;
                }
            }while(repeat);
            }
    }
}
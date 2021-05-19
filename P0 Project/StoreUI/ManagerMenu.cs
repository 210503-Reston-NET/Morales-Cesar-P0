using System;
//using BusLog;
//using CustDatLog;
//using StoreBusLog;
//using StoreDatLog;
namespace StoreUI
{
    public class ManagerMenu : IOpening
    {
        private IOpening menu1;

        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("What would you like to do manager?");
                Console.WriteLine("[0] replinish inventory");
                Console.WriteLine("[1] Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                case "0":
                    menu1 = Opening.GetMenu("ManagerInventoryMenu");
                    menu1.Start();
                    break;
                case "1":
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Please insert a proper response");
                    break;
                }
            }while(repeat);
            }
    }
}
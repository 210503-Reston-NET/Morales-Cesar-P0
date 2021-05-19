
using StoreModels;
using System;
using BusLog;
namespace StoreUI
{
    public class MainMenu : IOpening
    {
     
         private IBusLog _BusLog;
        private IOpening menu1;
        
        Validations _validate;
        public MainMenu(IBusLog BusLog, Validations validate)
        {
                _BusLog = BusLog;
                _validate = validate;
        }

        public void Start()
        {

        

            bool repeat = true;
            do{
                Console.WriteLine("Welcome to the PokeStop");
                Console.WriteLine("Are you a customer or a manager?");
                Console.WriteLine("[0] Customer");
                Console.WriteLine("[1] Manager");
                Console.WriteLine("[2] Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                case "0":
                    menu1 = Opening.GetMenu("Customer");
                    menu1.Start();
                    break;
                case "1":
                    FindManager();
                    menu1 = Opening.GetMenu("Manager");
                    menu1.Start();
                    break;
                case "2":
                    Console.WriteLine("Thank you! Have a good day!");
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Please input a valid option");
                    break;
                }
            }while(repeat);


        }



            public void FindManager()
            {
                bool repeatss = true;
                do
                {
                 try
                {
                    int pin = _validate.ValidateInt("Please enter your 4 digit ID");
                    //CREATE A DO WHILE LOOP HERE
                    repeatss= !(_BusLog.GetManagerT(pin));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                //return _customerBusLog.GetCustomer(pin);
                }while(repeatss);
        }

    }
}
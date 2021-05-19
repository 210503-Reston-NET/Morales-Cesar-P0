using System;
using StoreModels;
using BusLog;
namespace StoreUI
{
    public class CustomerMenu : IOpening
    {
        private IBusLog _BusLog;
        private IOpening menu1;
        
        Validations _validate;
        public CustomerMenu(IBusLog BusLog, Validations validate)
        {
                _BusLog = BusLog;
                _validate = validate;
        }

        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("Are you an existing customer or new customer?");
                Console.WriteLine("[0] New Customer");
                Console.WriteLine("[1] Existing Customer");
                Console.WriteLine("[2] Go Back");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        
                        AddACustomer();
                        menu1 = Opening.GetMenu("ExistingCustomer");
                        menu1.Start();
                        break;
                    case "1":
                        
                        FindCustomer();
                        menu1 = Opening.GetMenu("ExistingCustomer");
                        menu1.Start();
                        break;
                    case "2":
                        repeat = false;
                        break;
                }
            }while (repeat);
        }

        public void AddACustomer()
        {
            bool repeatss = true;
            do
            {
            string names = _validate.ValidateString("Please enter your Name");
            string hometown = _validate.ValidateString("Please enter your hometown");
            Random nums = new Random();
            int ID = nums.Next(1111,9999);
            try
            {
                Customer newCustomer = new Customer(names, ID, hometown);
                Customer createdCustomer = _BusLog.AddCustomer(newCustomer);
                Console.WriteLine(createdCustomer.ToString());
                repeatss = !(_BusLog.GetCustomerT(ID));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }while(repeatss);
        }

        public void FindCustomer()
        {
            bool repeatss = true;
            do
            {
                 try
            {
            int pin = _validate.ValidateInt("Please enter your 4 digit ID");
            //CREATE A DO WHILE LOOP HERE
            repeatss= !(_BusLog.GetCustomerT(pin));
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
using StoreModels;
using System;
using BusLog;
namespace StoreUI
{
    public class ManagerInventoryMenu : IOpening
    {  private IBusLog _BusLog;
        private IOpening menu1;
        
        Validations _validate;
        public ManagerInventoryMenu(IBusLog BusLog, Validations validate)
        {
                _BusLog = BusLog;
                _validate = validate;
        }
        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("What would you like to do Manager?");
                Console.WriteLine("[0] Update Inventory");
                Console.WriteLine("[1] Exit");
                string input = Console.ReadLine();
                switch(input)
                {
                case "0":
                    int prods = FindProduct(); 
                    int strf = FindStorefront();
                    Inventory newInventory = _BusLog.GetInventory(prods, strf);
                    Product newProduct = _BusLog.GetProduct3(prods);
                    Storefront newStorefront= _BusLog.GetStorefront3(strf);
                    Console.WriteLine($"{newProduct.ProductName} in {newStorefront.Town} Location");
                    Console.WriteLine($"There is currently {newInventory.InventoryQuantity} right now.");
                    int amount = _validate.ValidateInt("How many is there now?");
                    newInventory.InventoryQuantity = amount;
                    _BusLog.UpdateInventory(newInventory);
                    
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
    


        
            public int FindProduct()
            {
                int prodnum; 
                bool repeatss = true;
                do
                {
                    prodnum = _validate.ValidateInt("What is the product number? Please use 1-15");
                    //CREATE A DO WHILE LOOP HERE
                    repeatss= !(_BusLog.GetProductT(prodnum));
                    
                }while(repeatss);
                return prodnum;
                
            }


            public int FindStorefront()
            {
                bool repeatss = true;
                int pins;
                do
                {
                    
                    int pin;
                    pin = _validate.ValidateInt("From which store are you reporting from? Please use 10001-10012");
                    //CREATE A DO WHILE LOOP HERE
                    repeatss= !(_BusLog.GetStorefrontT(pin));
                    
                    pins = pin;
                }while(repeatss);
                return pins;
            }
        
        
        
        
        
        
        
        
        
        
        




    }
}
using System;
using StoreModels;
using BusLog;

namespace StoreUI
{
    public class PlaceOrder : IOpening
    {
        private IBusLog _BusLog;
        private IOpening menu1;
        
        Validations _validate;
        public PlaceOrder(IBusLog BusLog, Validations validate)
        {
                _BusLog = BusLog;
                _validate = validate;
        }

        public void Start()
        {   
            int red = Locationlock();
            bool repeat = true;
            Random nums = new Random();
            int ID = nums.Next(100,999);
            
                int custpin;
                custpin = FindCustomer();
            
                Customer newCustomer = _BusLog.GetCustomer3(custpin);
                Storefront orderStorefront = _BusLog.GetStorefront3(red);
                Order newOrder = new Order(ID, red, 0.0, custpin);

                Order createdOrder = _BusLog.AddOrder(newOrder);
                do{
                Console.WriteLine("What would you like to Order Customer?");
                Console.WriteLine("[0] Bicycle");
                Console.WriteLine("[1] Pokeball");
                Console.WriteLine("[2] Great ball"); 
                Console.WriteLine("[3] Ultra ball");
                Console.WriteLine("[4] Antidote");
                Console.WriteLine("[5] Paralyze Heal"); 
                Console.WriteLine("[6] Burn Heal");
                Console.WriteLine("[7] Awakening"); 
                Console.WriteLine("[8] Escape Rope");
                Console.WriteLine("[9] Repel"); 
                Console.WriteLine("[10] Super Repel");
                Console.WriteLine("[11] Max Repel");
                Console.WriteLine("[12] Potion");
                Console.WriteLine("[13] Super Potion");
                Console.WriteLine("[14] Hyper Potion");
                Console.WriteLine("[15] Full Restore");
                Console.WriteLine("[16] Complete Order");
                Console.WriteLine("[17] Go Back");
                string input = Console.ReadLine();
                
                switch(input)
                {
                case "0":
                    int quants = _validate.ValidateInt("How many would you like?");
                    double api = quants;
                    Product orderedItem = _BusLog.GetProduct3(0);
                    Inventory newInventory = _BusLog.GetInventory(0, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    double newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "1":
                    newInventory = _BusLog.GetInventory(1, newOrder.Storefrontsss);
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(1);
                    newInventory = _BusLog.GetInventory(1, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "2":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(2);
                    newInventory = _BusLog.GetInventory(2, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "3":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(3);
                    newInventory = _BusLog.GetInventory(3, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "4":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(4);
                    newInventory = _BusLog.GetInventory(4, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "5":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(5);
                    newInventory = _BusLog.GetInventory(5, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "6":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(6);
                    newInventory = _BusLog.GetInventory(6, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "7":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(7);
                    newInventory = _BusLog.GetInventory(7, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "8":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(8);
                    newInventory = _BusLog.GetInventory(2, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "9":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(9);
                    newInventory = _BusLog.GetInventory(9, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "10":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(10);
                    newInventory = _BusLog.GetInventory(10, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "11":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(11);
                    newInventory = _BusLog.GetInventory(11, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "12":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(12);
                    newInventory = _BusLog.GetInventory(12, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "13":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(13);
                    newInventory = _BusLog.GetInventory(13, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "14":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(14);
                    newInventory = _BusLog.GetInventory(14, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "15":
                    quants = _validate.ValidateInt("How many would you like?");
                    api = quants;
                    orderedItem = _BusLog.GetProduct3(15);
                    newInventory = _BusLog.GetInventory(15, newOrder.Storefrontsss);
                    if(newInventory.InventoryQuantity < quants)
                    {
                        Console.WriteLine("I'm Sorry we do not have enough of that Item... OOF");
                        break;
                    }
                    newPrice = orderedItem.ProductPrice * api;
                    newOrder.Total = newOrder.Total + newPrice;
                    _BusLog.UpdateOrder(newOrder);
                    break;
                case "16":
                    if(newOrder.Total== 0.0)
                    {
                        break;
                    }
                    Storefront orderLocation = _BusLog.GetStorefront3(newOrder.Storefrontsss);
                    Console.WriteLine($"Thank you! Your Order number is: {newOrder.ID}\n You placed your order in the {orderLocation.Town} Location\n Your total is {newOrder.Total}");
                    repeat = false;
                    break;
                default:
        
                    Console.WriteLine("Please select a proper option");
                    break;
                
                }
            }while(repeat);
            }

            public int Locationlock ()
            {          
        
                    bool repeats = true;
                    do{

                        Console.WriteLine("From which Location?");
                        Console.WriteLine("[1] Viridian City");
                        Console.WriteLine("[2] Pewter City");
                        Console.WriteLine("[3] Mt. Moon");
                        Console.WriteLine("[4] Cerulean City");
                        Console.WriteLine("[5] Lavender Town");
                        Console.WriteLine("[6] Celedon City");
                        Console.WriteLine("[7] Vermillion City");
                        Console.WriteLine("[8] Fushia City");
                        Console.WriteLine("[9] Saffron City");
                        Console.WriteLine("[10] Cinnabar Island");
                        Console.WriteLine("[11] Indigo Plateau");
                        int code = _validate.ValidateInt("Please chose from 1 to 11");

                        switch(code)
                    {   
                        case 1:
                            return 10001;
                            repeats = false;
                            break;
                        case 2:
                            return 10002;
                            repeats = false;
                            break;
                        case 3:
                            return 10003;
                            repeats = false;
                            break;
                        case 4:
                            return 10004; 
                            repeats = false;  
                            break;
                        case 5:
                            return 10005;
                            repeats = false;
                            break;
                        case 6:
                            return 10006;
                            repeats = false;
                            break;
                        case 7:
                            return 10007;
                            repeats = false;
                            break;
                        case 8:
                            return 10008;
                            repeats = false;
                            break;
                        case 9:
                            return 10009;
                            repeats = false;
                            break;
                        case 10:
                            return 10010;
                            repeats = false;
                            break;
                        case 11:
                            return 10011;
                            repeats = false;
                        default:
                            Console.WriteLine("Please insert a number from 1-11");
                            break;
                        }
                        return 0;
                    }while(repeats); 
                }

            public int FindCustomer()
            {
            int pin;

            bool repeatss = true;
            do
            {
            
            pin = _validate.ValidateInt("Please enter your 4 digit ID");
            //CREATE A DO WHILE LOOP HERE
            repeatss= !(_BusLog.GetCustomerT(pin));
            }while(repeatss);
            Console.WriteLine($"{pin}");
            return pin;        
            }
            










        }
    }
    

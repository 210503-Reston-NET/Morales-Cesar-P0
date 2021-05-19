using System.Collections.Generic;
using System.Linq;
using StoreModels;
using System;
using Model = StoreModels;
using Entity = DatLog.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatLog
{
    public class RepoDB : IRepository
    {
         private Entity.pokestopstoreContext _context;
        
        public RepoDB(Entity.pokestopstoreContext context)
        {
            _context = context;
        } 

        public Model.Customer AddCustomer(Model.Customer customer)
        {

            _context.Customers.Add(
            new Entity.Customer
            {
                CustomerName = customer.name,
                CustomerPassword = customer.ID,
                Customerhometown = customer.hometown,
            }
            );
            _context.SaveChanges();
            return customer;
        }

        public Model.Customer GetCustomer(Model.Customer customer)
                {
                    Entity.Customer found = _context.Customers.FirstOrDefault(custo => custo.CustomerPassword == customer.ID);  
                    if (found == null) return null;
                    return new Model.Customer(customer.name, found.CustomerPassword, customer.hometown);
                }

        
        public Model.Customer GetCustomers(Model.Customer customer) // Customer Creation
                {
                    Entity.Customer found = _context.Customers.FirstOrDefault(custo => custo.CustomerName == customer.name && custo.Customerhometown == customer.hometown);  
                    if (found == null) return null;
                    return new Model.Customer(customer.name, found.CustomerPassword, customer.hometown);
                }
                
/// <summary>
/// All of these enclosed by the summary comments are for True/False scenarios
/// </summary>
/// <param name="pin"></param>
/// <returns></returns>
                public bool GetCustomerT(int pin)         // Login Interface
                {
                    Entity.Customer found = _context.Customers.FirstOrDefault(custo => custo.CustomerPassword == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Customer with that PIN");
                        return false;}
                    return true;
                }

                public bool GetManagerT(int pin)         // Login Interface
                {
                    Entity.Manager found = _context.Managers.FirstOrDefault(manag => manag.ManagerId == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Manager with that PIN");
                        return false;}
                    return true;
                }

                
                public bool GetProductT(int pin)         // Login Interface
                {                                        //ADD PRODUCT ID UPON UNCOMMENTING
                    Entity.Product found = _context.Products.FirstOrDefault(produ => produ.ProductCode == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Product with that PIN");
                        return false;}
                    return true;
                }
                public bool GetStorefrontT(int pin)         // Login Interface
                {                                           //ADD STORE ID UPON UNCOMMENTING
                    Entity.Storefront found = _context.Storefronts.FirstOrDefault(storef => storef.StorefrontId == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Store with that PIN");
                        return false;}
                    return true;
                }
                

/// <summary>
/// Everything above this but below the first summary breakoff is a true/false getters
/// Everything below between this and the 3rd summary breakoffs are getters but with an int value 
/// </summary>
/// <param name="pin"></param>
/// <returns></returns>
                
                
                public Customer GetCustomerss(int pin)         // Login Interface
                {
                    Entity.Customer found = _context.Customers.FirstOrDefault(custo => custo.CustomerPassword == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Customer with that PIN");
                        return null;}
                    return new Model.Customer(found.CustomerName, found.CustomerPassword, found.Customerhometown);

                }
                public Manager GetManagerss(int pin)
                {
                    Entity.Manager found = _context.Managers.FirstOrDefault(manag => manag.ManagerId == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Customer with that PIN");
                        return null;}
                    return new Model.Manager(found.ManagerName, found.ManagerId);
                }

                public Order GetOrderss(int pin)
                {
                    Entity.Order found = _context.Orders.FirstOrDefault(ordes => ordes.OrderId == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Order with that PIN");
                        return null;}
                    return new Model.Order(found.OrderId, found.OrderStroreFrontId, found.OrderTotal, found.OrderCustomerId);
                }

        
                public Product GetProductss(int pin)            //ADD PRODUCT ID UPON UNCOMMENTING
                {
                    Entity.Product found = _context.Products.FirstOrDefault(produc => produc.ProductCode == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Product with that PIN");
                        return null;}
                    return new Model.Product(found.ProductName, found.ProductPrice, found.ProductCode);
                }

                public Storefront GetStorefrontss(int pin)              //ADD STORE ID UPON UNCOMMENTING                     
                {                                                               
                    Entity.Storefront found = _context.Storefronts.FirstOrDefault(storefr => storefr.StorefrontId == pin);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Storefront with that PIN");
                        return null;}
                    return new Model.Storefront(found.StorefrontTown, found.StorefrontId);
                }
        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

            public List<Customer> GetAllCustomers()
            {
                return _context.Customers
                .Select(
                customer => new Model.Customer(customer.CustomerName, customer.CustomerPassword, customer.Customerhometown)
                ).ToList();
            }

        public List<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new System.NotImplementedException();
        }



        public Model.Order AddOrder(Order order)
        {                   //ID, STOREFRONT ID, TOTAL, CUSTOMERNUMBER
   
            _context.Orders.Add(
            new Entity.Order
            {
                OrderId = order.ID,
                OrderTotal = order.Total,
                OrderCustomerId = order.customernumber,
                OrderStroreFrontId = order.Storefrontsss
                
                
            }
            );
            _context.SaveChanges();
        
            return order;
        }




        
        public Model.Order GetOrder(int id, int cust)
        {                                   //ID, STOREFRONT ID, TOTAL, CUSTOMERNUMBER
                  Entity.Order found = _context.Orders.FirstOrDefault(ordes => ordes.OrderId == id && ordes.OrderCustomerId == cust);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Order with that PIN");
                        return null;}
                    return new Model.Order(found.OrderId, found.OrderStroreFrontId, found.OrderTotal, found.OrderCustomerId);
        }

        
        public Model.Inventory GetInventory(int id, int cust)

       {                           
          
                                                  //ID, STOREFRONT ID, TOTAL, CUSTOMERNUMBER
                  Entity.Inventory found = _context.Inventories.FirstOrDefault(inven => inven.InventoryName == id && inven.StoreId == cust);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Inventory with that combination");
                        return null;}
                    return new Model.Inventory(found.InventoryId, found.InventoryQuantity, found.InventoryName, found.StoreId);
        }


        public void Inventory(Inventory inventory2BeUpdated)
        {
           
            Entity.Inventory oldInventory = _context.Inventories.Find(inventory2BeUpdated.InventoryId);
        
            _context.Entry(oldInventory).CurrentValues.SetValues(inventory2BeUpdated);
           

            Entity.Inventory oldInventorys = _context.Inventories.Find(inventory2BeUpdated.InventoryId);
           
        
            oldInventorys.InventoryQuantity = inventory2BeUpdated.InventoryQuantity;
            
             _context.Entry(oldInventory).CurrentValues.SetValues((inventory2BeUpdated));
            

            _context.SaveChanges();
           

          
            //_context.ChangeTracker.Clear();
        }  



    
        public void UpdateOrder(Order order2BeUpdated)
        {
           
            Entity.Order oldOrder = _context.Orders.Find(order2BeUpdated.ID);
        
            _context.Entry(oldOrder).CurrentValues.SetValues(order2BeUpdated);
           

            Entity.Order oldOrderss = _context.Orders.Find(order2BeUpdated.ID);
           
        
            oldOrderss.OrderTotal = order2BeUpdated.Total;
            
             _context.Entry(oldOrder).CurrentValues.SetValues((order2BeUpdated));
            

            _context.SaveChanges();
           

          
            //_context.ChangeTracker.Clear();
        }  


        public bool GetOrderT(int pin)
        {
            
            Entity.Order found = _context.Orders.FirstOrDefault(ordes => ordes.OrderId == pin );  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Order with that PIN");
                        return false;}
                    return true;
        }
/*








        public Model.Order GetLineItem(int id, int cust)
        {                                   //ID, STOREFRONT ID, TOTAL, CUSTOMERNUMBER
                  Entity.LineItem found = _context.LineItems.FirstOrDefault(linei => linei.OrderId == id && linei.OrderCustomerId == cust);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find LineItem with that combination");
                        return null;}
                    return new Model.LineOrder(found., found., found., found.);
        }

        public Model.Inventory AddInventory(Inventory inventory)
        {                   //ID, STOREFRONT ID, TOTAL, CUSTOMERNUMBER
            Console.WriteLine("YO ADRIAN WE MADE IT");
            _context.Inventories.Add(
            new Entity.Inventiory
            {
                OrderId = order.ID,
                OrderTotal = order.Total,
                OrderCustomerId = order.customernumber,
                OrderStroreFrontId = order.Storefrontsss
                
                
            }
            );
            _context.SaveChanges();
            Console.WriteLine("YO ADRIAN WE MADE IT");
            return inventory;
        }
        
        public Model.LineItem AddLineItem(LineItem lineItem)
        {                   //ID, STOREFRONT ID, TOTAL, CUSTOMERNUMBER
            Console.WriteLine("YO ADRIAN WE MADE IT");
            _context.LineItems.Add(
            new Entity.LineItem
            {
                OrderId = order.ID,
                OrderTotal = order.Total,
                OrderCustomerId = order.customernumber,
                OrderStroreFrontId = order.Storefrontsss
                
                
            }
            );
            _context.SaveChanges();
            Console.WriteLine("YO ADRIAN WE MADE IT");
            return lineItem;
        }

        public bool GetStorefrontT(int pin, int )         // Login Interface
                {                                           //ADD STORE ID UPON UNCOMMENTING

                 Entity.Inventory found = _context.Inventories.FirstOrDefault(inven => inven.OrderId == id && inven.OrderCustomerId == cust);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find Inventory with that combination");
                        return false;}
                    return true



                }
        public bool GetStorefrontT(int pin, int)         // Login Interface
                {                                           //ADD STORE ID UPON UNCOMMENTING
                  Entity.LineItem found = _context.LineItems.FirstOrDefault(linei => linei.OrderId == id && linei.OrderCustomerId == cust);  
                    if (found == null) 
                    { Console.WriteLine("Did Not find LineItem with that combination");
                        return false;}
                    return true;
                    }

*/





























































































        /*
           public Model.Customer GetInventory(Model.Inventory inventory)
           {
               Entity.Inventory found = _context.Inventories.FirstOrDefault(inven => inven.StoreId == inventory.StoreId && inven.InventoryName == inventory.InventoryName);  
               if (found == null) return null;                    
               return new Model.Inventory(found.InventoryId, found.InventoryQuantity, found.InventoryName, found.StoreId);
           }
           public Model.LineItem GetLineItem(Model.LineItem lineItem)
           {
               Entity.LineItem found = _context.LineItems.FirstOrDefault(lineo => lineo.productID == lineItem.productID && lineo.orderID == lineItem.orderID);  
               if (found == null) return null;
               return new Model.LineItem(found.LineitemId, found.LineitemQuantity, found.LineorderId, found.LineproductId);
           }
           public Model.Order GetOrder(Model.Order order)
           {
               Entity.Order found = _context.Orders.FirstOrDefault(orde => orde.OrderCustomerId == order.customernumber && orde.OrderId == order.ID);  
               if (found == null) return null;
                               return new Model.Order(found.Dates, found.OrderId, found.OrderTotal, found.OrderCustomerId, found.OrderStroreFrontId);
               }
                


               public Model.Product GetProduct(Model.Product product)
               {
                   Entity.Product found = _context.Products.FirstOrDefault(produ => produ.ProductCode == product.ProductCode);  
                   if (found == null) return null;
                   return new Model.Product(found.ProductName, found.ProductPrice, found.ProductCode);
               }

               public Model.Storefront GetStorefront(Model.Storefront storefront)
               {
                   Entity.Storefront found = _context.Storefronts.FirstOrDefault(storef => storef.StorefrontId == storefront.storeID);  
                   if (found == null) return null;
                   return new Model.Storefront(found.StorefrontTown, found.StorefrontId);
               }




       public List<Product> GetAllProducts()
       {
           throw new System.NotImplementedException();
       }

       public List<Storefront> GetStorefronts()
       {
           throw new System.NotImplementedException();
       }

       public List<Order> GetOrders()
       {
           throw new System.NotImplementedException();
       }



       /*        public Model.Storefront AddStorefront (Model.Storefront storefront)
               {
                       _context.Storefronts.Add(
                           new Entity.Storefront
                           {
                               StorefrontId = storefront.ID,
                               StorefrontTown= storefront.town,
                           }
                       );
                       _context.SaveChanges();
                       return storefront;
               }   
                public Model.Customer AddStorefront(Model.Storefront Storefront)
               {

                   _context.Storefront.Add(
                   new Entity.Storefront
                   {
                       town = Storefront.town
                   }
                   );
                   _context.SaveChanges();
                   return Storefront;
               }

               public Model.Order AddOrder(Model.Order order)
               {

                   _context.Order.Add(
                   new Entity.Order
                   {
                       id = GetCustomer(customer).ID,
                       Storefront = order.Storefront,
                       total =  order.total,
                       ordernumber = order.ordernumber
                   }
                   );
                   _context.SaveChanges();
                   return order;
               }

               public Model.Product AddProduct(Model.Product product)
               {

                   _context.Product.Add(
                   new Entity.Product
                   {
                       name = product.name,
                       price = product.price
                   }
                   );
                   _context.SaveChanges();
                   return product;
               }

               public List<Model.Customer> GetAllCustomers()
               {
                   return _context.Customers
                   .Select(
                       customer => new Model.Customer(customer.name, customer.id, customer.hometown)
                   ).ToList();
               }

               public List<Model.Customer> GetAllOrders()
               {
                   return _context.Orders
                   .Select(
                       order => new Model.Order(order.id, order.Storefront, order.total, order.ordernumber)
                   ).ToList();
               }

               public List<Model.Customer> GetAllStorefronts()
               {
                   return _context.Storefronts
                   .Select(
                       Storefront => new Model.Storefront(Storefront.name)
                   ).ToList();
               }

               public List<Model.Product> GetAllProducts()
               {
                   return _context.Products
                   .Select(
                       product => new Model.Product(product.name, product.price)
                   ).ToList();
               }



               public Model.Store GetOrder(Model.Order order)
               {
                   return _context.Orders.Where(
                       order => order.id == GetCustomer(customer).Id
                       ).Select(
                           order => new Model.Order
                           {
                               Id = order.id,
                               Storefront = order.Storefront,
                               Total = order.total,
                               Ordernumber = order.ordernumber

                           }
                       ).ToList();
               }

               public Model.Store GetProduct(Model.Product product)
               {
                   Entity.Product found = _context.Product.FirstOrDefault(produ => produ.Name == product.name && produ.price == product.price);  
                   if (found == null) return null;
                   return new Model.Product(found.name, found.price);
               }

               public Model.Store GetStorefront(Model.Storefront Storefront)
               {
                   Entity.Storefront found = _context.Storefront.FirstOrDefault(locat => locat.Name == Storefront.name);  
                   if (found == null) return null;
                   return new Model.Storefront(found.name);
               }
               */

    }
}


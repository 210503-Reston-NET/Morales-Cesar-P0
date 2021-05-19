
using System;
using System.Collections.Generic;
using DatLog;
using StoreModels;

namespace BusLog
{

    public class BusLogs : IBusLog
    {

        private IRepository _repo;
        public int pin;
        public BusLogs(IRepository repo)
        {
            _repo = repo;
        }
        
        public Customer AddCustomer(Customer customer)
         {  
            
            if(_repo.GetCustomers(customer)!=null)
            {
                throw new Exception ("Customer already exists... OOFERS");
            }
            return _repo.AddCustomer(customer);
         }
       public List<Customer> GetAllCustomers()
        {
            return _repo.GetAllCustomers();
        }

        public Customer GetCustomer(Customer customer)
        {
            return _repo.GetCustomer(customer);
        }

        public Customer GetCustomer3(int pin)
        {
           
            return _repo.GetCustomerss(pin);
        }

        public bool GetCustomerT(int pin)
        {
           
            return _repo.GetCustomerT(pin);
        }

        public bool GetManagerT(int pin)
        {
           
            return _repo.GetManagerT(pin);
        }


        public bool GetProductT(int pin)
        {
           
            return _repo.GetProductT(pin);
        }
        public bool GetStorefrontT(int pin)
        {
           
            return _repo.GetStorefrontT(pin);
        }

        public bool GetOrderT(int pin)
        {
           
            return _repo.GetOrderT(pin);
        }


        public Storefront GetStorefront3(int pin)
        {
               return _repo.GetStorefrontss(pin);
        }
           
        public Product GetProduct3(int pin)
        {
            return _repo.GetProductss(pin);
        }  
        

        public Manager GetManager3 (int pin)
        {
            return _repo.GetManagerss(pin);
        }

        public Order GetOrder3 (int pin)
        {
            return _repo.GetOrderss(pin);
        }
        public Customer GetCustomer2(Customer customer)
        {
            return _repo.GetCustomers(customer);
        }


        
            public Order AddOrder(Order order)
            {  
              return _repo.AddOrder(order);
            }

            public Order GetOrder(int id, int cust )
            {
                return _repo.GetOrder(id , cust);
            }
        
            public Inventory GetInventory(int id, int cust )
            {
                return _repo.GetInventory(id , cust);
            }

            public void UpdateInventory(Inventory inventory2BeUpdated)
            {
                _repo.Inventory(inventory2BeUpdated);
            }

            public void UpdateOrder(Order order2BeUpdated)
            {
                _repo.UpdateOrder(order2BeUpdated);
            }
    
        /*
            public Inventory AddInventory(Inventory inventory)
            {  
              return _repo.AddInventory(inventory);
            }

            

            public Inventory GetInventory3(int id, int cust )
            {
                return _repo.GetInventoryT(id , cust);
            }


            public LineItem AddLineItem(LineItem lineitem)
            {  
              return _repo.AddLineItem(order);
            }

            public LineItem GetLineItem(int id, int cust )
            {
                return _repo.GetLineItem(id , cust);
            }

            public LineItem GetLineItemy3(int id, int cust)
            {
                return _repo.GetLineItemT(id , cust);
            }









        */






        /*
           public Storefront AddStorefront(Storefront Storefront)
            {  
              return _repo.AddStorefront(Storefront);
            }
           public List<Storefront> GetAllStorefronts()
           {
               return _repo.GetAllStorefronts();
           }

             


           //public Customer AddProduct(Product product)
            //{  
              //return _repo.AddProduct(product);
            //}
           public List<Product> GetAllProducts()
           {
               return _repo.GetAllProducts();
           }

           



           
           public List<Order> GetAllOrders()
           {
               return _repo.GetAllOrders();
           }

          
           */
    }
}
using System.Collections.Generic;
using System;
using StoreModels;

namespace BusLog
{
    public interface IBusLog
    {
        List<Customer> GetAllCustomers();
        Customer AddCustomer(Customer customer);
        Customer GetCustomer(Customer customer);
        Customer GetCustomer3(int pin);
        bool GetCustomerT(int pin);
        bool GetManagerT(int pin);
        
        bool GetProductT(int pin);
        bool GetStorefrontT(int pin);

        bool GetOrderT(int pin);
        Product GetProduct3(int pin);
        Storefront GetStorefront3(int pin);
        

        Customer GetCustomer2(Customer customer);
        Manager GetManager3 (int pin);
        Order GetOrder3 (int pin);

        Order AddOrder(Order order);
        Order GetOrder(int id, int cust );


        Inventory GetInventory(int id, int cust );
        void UpdateInventory(Inventory inventory2BeUpdated);
        void UpdateOrder(Order order2BeUpdated);
     
      /*
          public Inventory AddInventory(Order order);

          Inventory GetInventory(int id, int cust );

          Inventory GetInventory3(int id, int cust );
          
          LineItem AddLineItem(LineItem lineitem);

          LineItem GetLineItem(int id, int cust );

          LineItem GetLineItemy3(int id, int cust);
           









        */
     
     
     
     
     
     
     
     
     
     
     
     
     
     
     
      /*  List<Storefront> GetAllStorefronts();
        List<Product> GetAllProducts();
        List<Order> GetAllOrders();

       
       
        

        Storefront AddStorefront(Storefront Loctaion);
        Product AddProduct(Product Product);
        
        
        
        
        Storefront GetStorefront(Storefront Storefront);
        Product GetProduct(Product product);
        */

    }
}
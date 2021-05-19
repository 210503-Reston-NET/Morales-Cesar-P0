using System.Collections.Generic;
using StoreModels;
namespace DatLog
{
    public interface IRepository
    {
        List<Customer> GetAllCustomers();
        Customer AddCustomer(Customer customer);
        Customer GetCustomer(Customer customer);
        Customer GetCustomers(Customer customer);
        Customer GetCustomerss(int pin);

        bool GetCustomerT(int pin);

        bool GetManagerT(int pin);
        
        bool GetProductT(int pin);

        bool GetStorefrontT(int pin);
        
        Manager GetManagerss(int pin);
        Order GetOrderss(int pin);
        Product GetProductss(int pin);
        Storefront GetStorefrontss(int pin);




        Order AddOrder(Order order);
        Order GetOrder(int id, int cust);
        Inventory GetInventory(int id , int cust);
        void Inventory(Inventory inventory2BeUpdated);
        void UpdateOrder(Order order2BeUpdated);

        bool GetOrderT(int pin);

    /*  Inventory AddInventory(inventory); 
        
        Inventory GetInventoryT(id , cust);

        Inventory AddLineItem(lineitem); 
        Inventory GetLineItem(id , cust);
        Inventory GetLineItemT(id , cust);
    
    
    
    
    */


        //List<Storefront> GetStorefronts();
        //Customer GetStorefront(Storefront storefront);
        
        
        List<Product> GetAllProducts();
        List<Order> GetOrders();
        





    }
}
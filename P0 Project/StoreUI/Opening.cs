using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using BusLog;
using DatLog;
using DatLog.Entities;

namespace StoreUI
{
    public class Opening
    {
        public static IOpening GetMenu (string nextStep)
        {

            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            string connectionString = configuration.GetConnectionString("pokestop");
            DbContextOptions<pokestopstoreContext> options = new DbContextOptionsBuilder<pokestopstoreContext>()
            .UseSqlServer(connectionString)
            .Options;
            
            var context = new pokestopstoreContext(options);



            switch(nextStep.ToLower())
            {
                case "mainmenu":
                    return new MainMenu(new BusLogs(new RepoDB(context)), new Validations());
                case "customer":
                    return new CustomerMenu(new BusLogs(new RepoDB(context)), new Validations());  //new BusLog(new RepoDB(context)), new Validations()
                case "manager":
                    return new ManagerMenu();
                case "managerinventorymenu":
                return new ManagerInventoryMenu(new BusLogs(new RepoDB(context)), new Validations());
                case "existingcustomer":
                    return new ExistingCustomerMenu();
                case "placeorder":
                    return new PlaceOrder(new BusLogs(new RepoDB(context)), new Validations());
                case "vieworder":
                    return new ViewOrderC(new BusLogs(new RepoDB(context)), new Validations());
                case "viewinventoryc":
                    return new InventoryMenuC(new BusLogs(new RepoDB(context)), new Validations());
                    default:
                        return null;
            }
        }
    }
}
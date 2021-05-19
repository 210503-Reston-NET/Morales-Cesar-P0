using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
        public  Order (int id, int Storefrontsss, double total, int customernumber)
        {
            
            this.ID = id;
            this.Storefrontsss = Storefrontsss;
            this.Total =  total;
            this.customernumber = customernumber;

        }
        
        private int _Id;
        private double _Total;
        private double _OrderNumber;

        
        public int ID { get; set; }
            /*
            {get {return _Id;}
            set {
                    if (_Id <  999 || _Id > 10000)
                    {
                        throw new Exception("This should be a 4 digit ID number... OOF");
                    }
                    _Id = value;
            }*/
        
        public int Storefrontsss { get; set; }
        public double Total { get {return _Total;}
            set{
                if ( _Total < -.01)
                {
                    throw new Exception("Price must be greater than $0");
                }
                _Total = value;
                }
            }
        public int customernumber { get; set; }
        
        
        
        /*{get {return (int)_OrderNumber;}
            set {
                    if(_Id <  99 || _Id > 1000)
                    {
                        throw new Exception("Invalid Order Number... OOF");
                    }
                    _OrderNumber = value;
            }*/
        }
    }

        //TODO: add a property for the order LineItems

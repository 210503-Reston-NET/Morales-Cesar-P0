using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
         private double _Price;
        public Product (string ProductName, double ProductPrice, int ProductCode)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductCode = ProductCode;
        }   
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCode { get; set; }
        //todo: add more properties to define a product (maybe a category?)
    
    
        public override string ToString()
        {
            return $"Product: {ProductName} \n Price: {ProductPrice} \n Barcode {ProductCode}";
        }
    
    
    }
}
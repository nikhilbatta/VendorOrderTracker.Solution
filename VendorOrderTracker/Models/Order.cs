using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
    public class Order
    {
        public string OrderTitle {get;set;}
        public string Description{get;set;}
        public string Price{get;set;}
        public string DateOfOrder{get;set;}
        private static List<Order> OrderList = new List<Order>{};


        public Order(string aOrderTitle, string aDescription, string aPrice, string aDateOfOrder)
        {
            OrderTitle = aOrderTitle;
            Description = aDescription;
            Price = aPrice;
            DateOfOrder = aDateOfOrder;
        }
        public static List<Order> GetAll()
        {
            return OrderList;
        }
    }
}
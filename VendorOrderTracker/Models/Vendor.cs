using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public string Name {get;set;}
        public string Description{get;set;}
        public Guid ID {get;set;}
        public List<Order> listOfOrders;
       
    
    public Vendor(Guid ID, string aName, string aDescription)
    {
        this.ID = ID;
        Name = aName;
        Description = aDescription;
        listOfOrders = new List<Order>{};
        
    }
    public  void AddOrder(Order newOrder)
    {
        newOrder.ID = listOfOrders.Count;
        listOfOrders.Add(newOrder);
    }
    
    
     public Order FindOrderByID(int searchID)
        {
            foreach(Order orderItem in listOfOrders)
            {
                if(searchID == orderItem.ID)
                {
                    return orderItem;
                }
            }
            return null;
            
        }
    }
}
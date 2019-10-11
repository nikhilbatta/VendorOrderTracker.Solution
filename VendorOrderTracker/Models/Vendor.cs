using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public string Name {get;set;}
        public string Description{get;set;}
        public static List<Vendor> Instances = new List<Vendor>{};
        // public List<Order> Orders {get;set;}
    // public Vendor(string aName, string aDescription,Order orderObject)
    // {
    //     Name = aName;
    //     Description = aDescription;
    //     Instances.Add(this);
    //     Orders.Add(orderObject);
    // }
    public Vendor(string aName, string aDescription)
    {
        Name = aName;
        Description = aDescription;
        Instances.Add(this);
    }
    public static List<Vendor> GetAll()
    {
        return Instances;
    }
    }
}
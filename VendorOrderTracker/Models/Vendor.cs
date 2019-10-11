using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public string Name {get;set;}
        public string Description{get;set;}
        public int ID{get;set;}
        private static List<Vendor> Instances = new List<Vendor>{};
        // public List<Order> Orders {get;set;}
    public Vendor(string aName, string aDescription)
    {
        Name = aName;
        Description = aDescription;
        ID = Instances.Count + 1;
        Instances.Add(this);
    }
    public static List<Vendor> GetAll()
    {
        return Instances;
    }
    public static Vendor FindByID(int ID)
    {
        return Instances[ID];
    }
    }
}
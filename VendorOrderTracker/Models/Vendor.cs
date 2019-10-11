using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Models
{
    public class Vendor
    {
        public string Name {get;set;}
        public string Description{get;set;}
        public static List Instances {get;set;}
        public List Orders {get;set;}
    public Vendor(string aName, string aDescription, string aOrder)
    {
        Name = aName;
        Description = aDescription;
        Instances.Add(this);
        Orders = new List<string>{};
        
    }
    }
}
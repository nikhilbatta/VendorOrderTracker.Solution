using System.Collections.Generic;
using System;

 namespace VendorOrderTracker.Models
{
    public class Store
    {
        private List<Vendor> _vendors;
        private static Store _store;
        
        private Store()
        {
            _vendors = new List<Vendor>{};
        }
        public static Store Instance()
        {
            if(_store == null)
            {
                _store = new Store();
            }
            return _store;
        }
        public Vendor FindVendorByID(Guid ID)
        {
            foreach(Vendor customer in _vendors)
            {
                if(ID == customer.ID)
                {
                    return customer;
                }
            }
            return null;
        
        }
        public void DeleteVendorByID(Guid ID)
        {
            _vendors.Remove(Store.Instance().FindVendorByID(ID));
        }
        
    public Vendor CreateVendor(string aName, string aDescription)
    {
        var vendorID = System.Guid.NewGuid();
        Vendor newVendor = new Vendor(vendorID, aName, aDescription);
        _vendors.Add(newVendor);
        return newVendor;
    }
    public List<Vendor> GetAllVendors()
    {
        return _vendors;
    }
    }
}
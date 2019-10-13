using System.Collections.Generic;    
   
namespace VendorOrderTracker.Models  
{  
    public class SingleOrderViewModel  
    {  
        public Order Order { get; set; }  
        public Vendor Customer { get; set; }  
    }  
} 
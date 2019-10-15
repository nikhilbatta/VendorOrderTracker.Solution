using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendor/{ID}/allorders")]
        public ActionResult AllOrders(Guid ID)
        {  
            Vendor vendorOrders = Store.Instance().FindVendorByID(ID);
            return View(vendorOrders);
        }
        [HttpGet("/vendor/{ID}/neworder")]
        public ActionResult Order(Guid ID)
        {
            Console.WriteLine(ID);
            return View(ID);
        }
        [HttpGet("vendor/{vendorID}/orders/{orderID}")]
        public ActionResult SingleOrder(Guid vendorID, int orderID)
        {
            Vendor foundVendor = Store.Instance().FindVendorByID(vendorID);
            Order foundOrder = foundVendor.FindOrderByID(orderID);
             var SingleOrderViewModel = new SingleOrderViewModel  
            {  
                Order = foundOrder,  
                Customer = foundVendor  
            };
            return View(SingleOrderViewModel);

        }
        [HttpPost("/vendor/{ID}/allorders")]
        public ActionResult OrderIntoVendor(Guid ID,string aOrderTitle, string aDescription, string aPrice, string aDateOfOrder)
        {
            
            Vendor vendorInstance = Store.Instance().FindVendorByID(ID);
            
            Order newOrder = new Order(aOrderTitle, aDescription, aPrice, aDateOfOrder);
            Console.WriteLine(newOrder.ID);
            vendorInstance.AddOrder(newOrder);
            
            
            
            return Redirect("/vendor/" + ID + "/orders/" + newOrder.ID);
        }
        
    }
}
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
        public ActionResult Order(int ID)
        {
            return View(ID);
        }
        [HttpGet("vendor/{vendorID}/orders/{orderId}")]
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
            Console.WriteLine(ID);
            Vendor vendorInstance = Store.Instance().FindVendorByID(ID);
            Order newOrder = new Order(aOrderTitle, aDescription, aPrice, aDateOfOrder);
            vendorInstance.AddOrder(newOrder);
            
            return Redirect("/vendor/" + ID + "/orders/" + newOrder.ID);
        }
        
    }
}
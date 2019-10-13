using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendor/{ID}/allorders")]
        public ActionResult AllOrders(int ID)
        {  
            Vendor vendorOrders = Vendor.FindByID(ID);
            return View(vendorOrders);
        }
        [HttpGet("/vendor/{ID}/neworder")]
        public ActionResult Order(int ID)
        {
            return View(ID);
        }
        [HttpGet("vendor/{vendorID}/orders/{orderId}")]
        public ActionResult SingleOrder(int vendorID, int orderID)
        {
            Vendor foundVendor = Vendor.FindByID(vendorID);
            Order foundOrder = foundVendor.FindOrderByID(orderID);
             var SingleOrderViewModel = new SingleOrderViewModel  
            {  
                Order = foundOrder,  
                Customer = foundVendor  
            };
            return View(SingleOrderViewModel);

        }
        [HttpPost("/vendor/{ID}/allorders")]
        public ActionResult OrderIntoVendor(int ID,string aOrderTitle, string aDescription, string aPrice, string aDateOfOrder)
        {
            Order newOrder = new Order(aOrderTitle, aDescription, aPrice, aDateOfOrder);
            Vendor vendor = Vendor.FindByID(ID);
            vendor.AddOrder(newOrder);
            
            return Redirect("/vendor/" + ID + "/orders/" + newOrder.ID);
        }
        
    }
}
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
        [HttpPost("/vendor/{ID}/allorders")]
        public ActionResult OrderIntoVendor(int ID,string aOrderTitle, string aDescription, string aPrice, string aDateOfOrder)
        {
            Order newOrder = new Order(aOrderTitle, aDescription, aPrice, aDateOfOrder);
            Vendor vendorOrders = Vendor.FindByID(ID);
            vendorOrders.listOfOrders.Add(newOrder);
            return RedirectToAction("AllOrders");
        }
        
    }
}
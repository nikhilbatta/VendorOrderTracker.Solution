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
            return View(vendorOrders.listOfOrders);
        }
        [HttpGet("/order/{ID}")]
        public ActionResult Order()
        {
            return View();
        }
        [HttpPost("/order/new")]
        public ActionResult OrderIntoVendor(string aOrderTitle, string aDescription, string aPrice, string aDateOfOrder)
        {
            Order newOrder = new Order(aOrderTitle, aDescription, aPrice, aDateOfOrder);
            return RedirectToAction();
        }
        
    }
}
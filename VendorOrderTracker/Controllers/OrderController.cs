using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/order/{ID}")]
        public ActionResult Order()
        {
            return View();
        }
        [HttpPost("")]
        public ActionResult()
        
    }
}
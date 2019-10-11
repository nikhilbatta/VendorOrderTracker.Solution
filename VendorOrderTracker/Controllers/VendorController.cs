using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }
        [HttpGet("/vendors/newvendor")]
        public ActionResult NewVendor()
        {
            return View();
        }
        [HttpPost("/vendors")]
        public ActionResult ShowVendor(string aName, string aDescription)
        {
            Vendor newVendor = new Vendor(aName, aDescription);
            return RedirectToAction("Index");
        }
    }
}
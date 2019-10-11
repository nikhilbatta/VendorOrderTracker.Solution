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
        public ActionResult ShowAllVendors(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }
        [HttpGet("vendors/find")]
        public ActionResult FindVendorByID()
        {
            return View();
        }
        [HttpPost("vendor/found")]
        public ActionResult Found(int searchID)
        {
            Vendor foundVendor = Vendor.FindByID(searchID);
            return View(foundVendor);
        }
    }
}
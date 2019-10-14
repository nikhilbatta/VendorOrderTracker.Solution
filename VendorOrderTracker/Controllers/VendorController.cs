using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Store.Instance().GetAllVendors();
            return View(allVendors);
        }
        [HttpGet("/vendors/newvendor")]
        public ActionResult NewVendor()
        {
            return View();
        }
        [HttpPost("/vendors")]
        public ActionResult AddVendor(string vendorName, string vendorDescription)
        {
            Vendor newVendor = Store.Instance().CreateVendor(vendorName,vendorDescription);
            return RedirectToAction("Index");
        }
        [HttpGet("/vendors/find")]
        public ActionResult FindVendorByID()
        {
            return View();
        }
        [HttpPost("/vendor/found")]
        public ActionResult Found(Guid searchID)
        {
            Vendor foundVendor = Store.Instance().FindVendorByID(searchID);
            return View(foundVendor);
        }
        [HttpGet("/vendor/delete/{ID}")]
        public ActionResult DeleteVendorByID(Guid ID)
        {
            Store.Instance().DeleteVendorByID(ID);
            return RedirectToAction("Index");
        }
    }
}
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierreOrderApp.Models;

namespace PierreOrderApp.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName)
        {
            Vendor newVendor = new Vendor(vendorName);
            return RedirectToAction("Index");
        }
        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }
        [HttpPost("/vendors/{vendorID}/orders")]
        public ActionResult Create(int vendorID, string orderDetails)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorID);
            Order newOrder = new Order(orderDetails);
            foundVendor.AddOrder(newOrder);
            List<Order> vendorOrders = foundVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", foundVendor);
            return View("show", model);
        }
    }
}
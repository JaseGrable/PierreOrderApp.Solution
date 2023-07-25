using Microsoft.AspNetCore.Mvc;
using PierreOrderApp.Models;
using System.Collections.Generic;

namespace PierreOrderApp.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("vendors/{vendorID}/orders/new")]
        public ActionResult New(int vendorID)
        {
            Vendor vendor = Vendor.Find(vendorID);
            return View(vendor);
        }
        [HttpGet("vendors/{vendorID}/orders/{orderID}")]
        public ActionResult Show(int vendorID, int orderID)
        {
            Order order = Order.Find(orderID);
            Vendor vendor = Vendor.Find(vendorID);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("orders", order);
            model.Add("vendor", vendor);
            return View(model);
        }
    }
}
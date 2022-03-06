using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
using System.Collections.Generic;

namespace OrderTracker.Controllers
{
    public class OrderController : Controller
    {

      [HttpGet("/vendors/{vendorId}/orders/new")]
      public ActionResult New(int vendorId)
      {
        Vendor vendor = Vendor.Find(vendorId);
        return View(vendor);
      }

      [HttpPost("/orders/delete")]
      public ActionResult DeleteAll()
      {
        Order.ClearAll();
        return View();
      }

    [HttpGet("/categories/{vendorId}/items/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
    }
}
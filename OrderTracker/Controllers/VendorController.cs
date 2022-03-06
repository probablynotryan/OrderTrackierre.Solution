using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
    public class VendorController : Controller
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
      public ActionResult Create(string vendorName, string vendorDescription)
      {
        Vendor newVendor = new Vendor(vendorName, vendorDescription);
        return RedirectToAction("Index");
      }

      [HttpGet("/vendors/{id}")]
      public ActionResult Show(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedVendor = Vendor.Find(id);
        List<Order> vendorOrders = selectedVendor.Order;
        model.Add("vendor", selectedVendor);
        model.Add("order", vendorOrders);
        return View(model);
      }
      
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Show(int vendorId, string date, string title, string price, string description)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(date, title, price, description);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Order;
      model.Add("order", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }
    }
}
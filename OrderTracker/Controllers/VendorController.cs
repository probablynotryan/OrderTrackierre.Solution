using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/vendors")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
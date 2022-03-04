using Microsoft.AspNetCore.Mvc;

namespace OrderTracker.Controllers
{
    public class OrderController : Controller
    {

      [HttpGet("/orders")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
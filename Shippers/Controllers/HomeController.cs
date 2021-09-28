using Microsoft.AspNetCore.Mvc;
using Shippers.Models;

namespace Shippers.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [HttpPost("/parcel")]
      public ActionResult Parcel(float height, float length, float width, float weight)
      {
        Parcel userParcel = new Parcel(height, length, width, weight);
        userParcel.GetVolume();
        userParcel.CostToShip();
        return View(userParcel);
        
      }

    }
}
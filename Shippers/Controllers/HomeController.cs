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
        // if (height > 0 && length > 0 && width > 0 && weight > 0)
        // {
          Parcel userParcel = new Parcel(height, length, width, weight);
          userParcel.GetVolume();
          userParcel.CostToShip();
          return View(userParcel);
        // } else
        // {
        //   string errorMessage = "Invalid dimensions or weight. Please enter your information in whole positive numbers or decimals.";
        //   return View("Form", errorMessage);
        // }
        
      }

    }
}
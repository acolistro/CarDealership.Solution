using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "avoid this car");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "not your best choice");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "an OK vehicle");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "the budget choice");
      return View();
    }

  }
}

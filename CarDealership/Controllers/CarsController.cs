using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/add")]
    public ActionResult Add()
    {
      return View();
    }

    [HttpPost("/add")]
    public ActionResult Create(string makemodel, string price, string mileage, string message)
    {
      int intMileage = int.Parse(mileage);
      int intPrice = int.Parse(price);
      Car saleCar = new Car(makemodel, intPrice, intMileage, message);
      return RedirectToAction("Index");
    }

    [HttpPost("/search")]
    public ActionResult Search(string price, string mileage)
    {
      Car.SearchCars(price, mileage);
      return View(Car.CarsMatchingSearch);
    }

    [HttpGet("/index")]
    public ActionResult Index()
    {
      return View(Car.AllCars);
    }

  }
}
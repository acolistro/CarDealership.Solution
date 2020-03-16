using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Message { get; set; }
    public static List<Car> CarsMatchingSearch { get; set; } = new List<Car>() {};
    public static List<Car> AllCars { get; set; } = new List<Car>() {};
    
    public Car(string makeModel,  int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      AllCars.Add(this);
    }



    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price <= maxPrice && Miles <= maxMileage);
    }

    public static void SearchCars(string maxCash, string maxDistance)
    {
      int maxPrice = int.Parse(maxCash);
      int maxMileage = int.Parse(maxDistance);
      foreach (Car automobile in AllCars)
      {
        if (automobile.WorthBuying(maxPrice, maxMileage))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }
    }
  }
}
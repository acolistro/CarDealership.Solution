using System;

namespace Dealership.Models
{
  public class Car
  {
    public string _makeModel { get; set; }
    public int _price { get; set; }
    public int _miles { get; set; }
    public string _message { get; set; }

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (_price < maxPrice && _miles < maxMileage);
    }
  }
}
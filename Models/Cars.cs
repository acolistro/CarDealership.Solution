using System;

namespace Dealership.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;
    private string _message;

    public Car(string makeModel, int price, int miles, string message)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
      _message = message;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public bool WorthBuying(int _maxPrice, int _maxMileage)
    {
      return (_price < _maxPrice && _miles < _maxMileage);
    }
  }
}
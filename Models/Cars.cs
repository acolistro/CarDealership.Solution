namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel;
    public int Price;
    public int Miles;
    public string Message;

    public Car(string makeModel, int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price < maxPrice && Miles < maxMileage);
    }
  }
}
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public string Message { get; set; }
    public int Id { get; set; }
    public static List<Car> CarsMatchingSearch { get; set; } = new List<Car>() {};
    
    public Car(string makeModel,  int price, int miles, string message)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
    }
    public Car(string makeModel,  int price, int miles, string message, int id)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Message = message;
      Id = id;
    }

    public override bool Equals(System.Object otherCar)
    {
      if (!(otherCar is Car))
      {
        return false;
      }
      else
      {
        Car newCar = (Car) otherCar;
        bool makeModelEquality = (this.MakeModel == newCar.MakeModel);
        bool priceEquality = (this.Price == newCar.Price);
        bool milesEquality = (this.Miles == newCar.Miles);
        bool messageEquality = (this.Message == newCar.Message);
        bool idEquality = (this.Id == newCar.Id);
        return (makeModelEquality && priceEquality && milesEquality && messageEquality && idEquality);
      }
    }

    public static List<Car> GetAll()
    {
      List<Car> allCars = new List<Car> { };
      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM cars;";
      MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
      while (rdr.Read())
      {
          int carId = rdr.GetInt32(0);
          string makeModel = rdr.GetString(1);
          int price = rdr.GetInt32(2);
          int miles = rdr.GetInt32(3);
          string message = rdr.GetString(4);
          Car newCar = new Car(makeModel, price, miles, message, carId);
          allCars.Add(newCar);
      }
      conn.Close();
      if (conn != null)
      {
          conn.Dispose();
      }
      return allCars;
    }

    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM cars;";
      cmd.ExecuteNonQuery();
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public void Save()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"INSERT INTO cars (makeModel, price, miles, message) VALUES (@CarMakeModel, @CarPrice, @CarMiles, @CarMessage);";
      MySqlParameter makeModel = new MySqlParameter();
      makeModel.ParameterName = "@CarMakeModel";
      makeModel.Value = this.MakeModel;
      cmd.Parameters.Add(makeModel);
      MySqlParameter price = new MySqlParameter();
      price.ParameterName = "@CarPrice";
      price.Value = this.Price;
      cmd.Parameters.Add(price);
      MySqlParameter miles = new MySqlParameter();
      miles.ParameterName = "@CarMiles";
      miles.Value = this.Miles;
      cmd.Parameters.Add(miles);  
      MySqlParameter message = new MySqlParameter();
      message.ParameterName = "@CarMessage";
      message.Value = this.Message;
      cmd.Parameters.Add(message);               
      cmd.ExecuteNonQuery();
      Id = (int) cmd.LastInsertedId;
      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }

    public bool WorthBuying(int maxPrice, int maxMileage)
    {
      return (Price <= maxPrice && Miles <= maxMileage);
    }

    // public static void SearchCars(string maxCash, string maxDistance)
    // {
    //   int maxPrice = int.Parse(maxCash);
    //   int maxMileage = int.Parse(maxDistance);
    //   foreach (Car automobile in allCars)
    //   {
    //     if (automobile.WorthBuying(maxPrice, maxMileage))
    //     {
    //       CarsMatchingSearch.Add(automobile);
    //     }
    //   }
    // }
  }
}
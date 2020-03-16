using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CarDealership.Models;
using System;
using MySql.Data.MySqlClient;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTest : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }

    public CarTest()
    {
      DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=car_dealership_test;";
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_CarList()
    {
      List<Car> newList = new List<Car> { };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Equals_ReturnsTrueIfPropertiesAreTheSame_Car()
    {
      Car firstCar = new Car("1974 Volkswagen Thing", 1100, 368792, "avoid this car");
      Car secondCar = new Car("1974 Volkswagen Thing", 1100, 368792, "avoid this car");

      Assert.AreEqual(firstCar, secondCar);
    }

    [TestMethod]
    public void Save_SavesToDatabase_CarList()
    {
      Car testCar = new Car("1974 Volkswagen Thing", 1100, 368792, "avoid this car");
      testCar.Save();
      List<Car> result = Car.GetAll();
      List<Car> testList = new List<Car>{testCar};
      CollectionAssert.AreEqual(testList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_CarList()
    {
      Car newCar1 = new Car("1974 Volkswagen Thing", 1100, 368792, "avoid this car");
      newCar1.Save(); 
      Car newCar2 = new Car("1980 Yugo Koral", 700, 56000, "not your best choice");
      newCar2.Save();
      List<Car> newList = new List<Car> { newCar1, newCar2 };

      List<Car> result = Car.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    // [TestMethod]
    // public void Find_ReturnsCorrectItemFromDatabase_Item()
    // {
    //   Item newItem = new Item("Mow the lawn");
    //   newItem.Save();
    //   Item newItem2 = new Item("Wash dishes");
    //   newItem2.Save();

    //   Item foundItem = Item.Find(newItem.Id);
    //   Assert.AreEqual(newItem, foundItem);
    // }
  }
}
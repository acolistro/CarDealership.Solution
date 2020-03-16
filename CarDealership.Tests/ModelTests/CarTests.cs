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

    // [TestMethod]
    // public void Equals_ReturnsTrueIfDescriptionsAreTheSame_Item()
    // {
    //   Item firstItem = new Item("Mow the lawn");
    //   Item secondItem = new Item("Mow the lawn");

    //   Assert.AreEqual(firstItem, secondItem);
    // }

    // [TestMethod]
    // public void Save_SavesToDatabase_ItemList()
    // {
    //   Item testItem = new Item("Mow the lawn");
    //   testItem.Save();
    //   List<Item> result = Item.GetAll();
    //   List<Item> testList = new List<Item>{testItem};
    //   CollectionAssert.AreEqual(testList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   newItem1.Save(); // New code
    //   Item newItem2 = new Item(description02);
    //   newItem2.Save(); // New code
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   List<Item> result = Item.GetAll();

    //   CollectionAssert.AreEqual(newList, result);
    // }

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
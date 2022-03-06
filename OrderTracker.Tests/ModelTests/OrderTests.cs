using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;


namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order testOrder = new Order("TestAndTheFurious", "2Test2Furious", "TestAndTheFurious3", "AnotherTestString");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      // Arrange
      string price = "Four-fitty";
      // Act
      Order testOrder = new Order("DateString", "TitleString", "Four-fitty", "DescriptionString");
      string result = testOrder.Price;
      // Asset
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> testList = new List<Order> { };
      // Act
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(testList, result);
    }
  }
}
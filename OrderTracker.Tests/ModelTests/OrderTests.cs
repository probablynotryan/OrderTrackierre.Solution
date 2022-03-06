using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;


namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests
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
  }
}
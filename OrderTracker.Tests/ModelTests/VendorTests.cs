using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;


namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("TestWars:ANewTest", "TestWars:TheErrorsStrikeBack");
      Assert.AreNotEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}
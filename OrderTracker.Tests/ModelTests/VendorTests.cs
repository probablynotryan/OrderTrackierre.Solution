using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;


namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("TestWars:ANewTest", "TestWars:TheErrorsStrikeBack");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      // Arrange
      string name = "VendorJanice";
      Vendor testVendor = new Vendor("VendorJanice", "DescriptionYaddaYadda");
      // Act
      string testAgainst = testVendor.Name;
      // Assert
      Assert.AreEqual(testAgainst, name);
    }

    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      // Arrange
      string name = "Bestie Testie";
      Vendor testVendor = new Vendor(name, "DescriptionAndMoreWords");
      // Act
      int result = testVendor.Id;
      // Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      // Arrange
      Vendor testVendorUno = new Vendor("Barbara's Baked Breads", "Sells bread");
      Vendor testVendorDos = new Vendor("Papa Pete's Pristine Pastries", "Sells motor oil");
      //Act
      Vendor whatVendorIsIt = Vendor.Find(2);
      //Assert
      Assert.AreEqual(testVendorDos, whatVendorIsIt);
   }

    [TestMethod]
    public void AddOrder_ReturnsOrder_Order()
    {
      // Arrange
      Vendor testVendorUno = new Vendor("Barbara's Baked Breads", "Sells bread");
      Order barbOrder = new Order("cats", "and", "boots", "and");
      List<Order> checkList = new List<Order> {barbOrder};
      // Act
      testVendorUno.AddOrder(barbOrder);
      List<Order> testAgainst = testVendorUno.Order;
      // Assert
      CollectionAssert.AreEqual(checkList, testAgainst);
    }  

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      // Arrange
      Vendor testVendor = new Vendor("","");
      Vendor anotherVendor = new Vendor("","");
      List<Vendor> vendorList = new List<Vendor> {testVendor, anotherVendor};
      // Act
      List<Vendor> testResult = Vendor.GetAll();
      // Assert
      CollectionAssert.AreEqual(vendorList, testResult);
    }

    [TestMethod]
    public void ClearAll_RemovesAllVendorsFromList_True()
    {
      // Arrange
      Vendor bob = new Vendor("bob", "bob");
      List<Vendor> nothingHere = new List<Vendor> { };
      // Act
      Vendor.ClearAll();
      // Assert
      CollectionAssert.AreEqual(nothingHere, Vendor.GetAll());
    }
  }
}
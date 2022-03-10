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
  }
}
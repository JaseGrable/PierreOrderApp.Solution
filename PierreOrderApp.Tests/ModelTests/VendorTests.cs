using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreOrderApp.Models;
using System;


namespace PierreOrderApp.Tests
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
            Vendor newVendor = new Vendor("test vendor");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        [TestMethod]
        public void GetName_ReturnsName_String()
        {
            string name = "Test Vendor";
            Vendor newVendor = new Vendor(name);
            string result = newVendor.Name;
            Assert.AreEqual(name, result);
        }
        [TestMethod]
        public void GetID_ReturnsID_Int()
        {
            string name = "Test Vendor";
            Vendor newVendor = new Vendor(name);
            int result = newVendor.ID;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            string name01 = "Test Vendor 1";
            string name02 = "Test Vendor 2";
            Vendor newVendor1 = new Vendor(name01);
            Vendor newVendor2 = new Vendor(name02);
            List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
            List<Vendor> result = Vendor.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            string name01 = "Test Vendor 1";
            string name02 = "Test Vendor 2";
            Vendor newVendor1 = new Vendor(name01);
            Vendor newVendor2 = new Vendor(name02);
            Vendor result = Vendor.Find(2);
            Assert.AreEqual(newVendor2, result);
        }
        [TestMethod]
        public void AddOrder_AssociatesOrderWithVendor_OrderList()
        {
            string detail = "20 loaves";
            Order newOrder = new Order(detail);
            List<Order> newList = new List<Order> { newOrder };
            string name = "Test Vendor 1";
            Vendor newVendor = new Vendor(name);
            newVendor.AddOrder(newOrder);
            List<Order> result = newVendor.Orders;
            CollectionAssert.AreEqual(newList, result);

        }
    }
}
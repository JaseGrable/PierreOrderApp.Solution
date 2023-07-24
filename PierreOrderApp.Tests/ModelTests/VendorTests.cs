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

        }

    }
}
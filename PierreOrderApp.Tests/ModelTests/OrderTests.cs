using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreOrderApp.Models;
using System;

namespace PierreOrderApp.Tests
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
            Order newOrder = new Order("Test Order");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetDetails_ReturnsDetails_String()
        {
            string details = "20 loaves";
            Order newOrder = new Order(details);
            string result = newOrder.Details;
            Assert.AreEqual(details, result);
        }

        [TestMethod]
        public void SetDetails_SetDetails_String()
        {
            string details = "20 loaves";
            Order newOrder = new Order(details);
            string newDetails = "20 pastries";
            newOrder.Details = newDetails;
            string result = newOrder.Details;
            Assert.AreEqual(newDetails, result);
        }
    }
}
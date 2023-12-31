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
        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemList()
        {
            List<Order> newList = new List<Order> { };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetAll_ReturnsOrders_OrderList()
        {
            string details01 = "20 loaves";
            string details02 = "20 pastries";
            Order newOrder1 = new Order(details01);
            Order newOrder2 = new Order(details02);
            List<Order> newList = new List<Order> { newOrder1, newOrder2 };
            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }
        [TestMethod]
        public void GetID_OrderInstantiatedWithAnIDAndGetterReturns_Int()
        {
            string details = "20 loaves";
            Order newOrder = new Order(details);
            int result = newOrder.ID;
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            string details01 = "20 loaves";
            string details02 = "20 pastries";
            Order newOrder1 = new Order(details01);
            Order newOrder2 = new Order(details02);
            Order result = Order.Find(2);
            Assert.AreEqual(newOrder2, result);
        }
    }
}
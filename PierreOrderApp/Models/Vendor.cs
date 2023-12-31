using System.Collections.Generic;

namespace PierreOrderApp.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public int ID { get; }
        private static List<Vendor> _instances = new List<Vendor> { };
        public List<Order> Orders { get; set; }

        public Vendor(string vendorName)
        {
            Name = vendorName;
            _instances.Add(this);
            ID = _instances.Count;
            Orders = new List<Order> { };
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static List<Vendor> GetAll()
        {
            return _instances;
        }
        public static Vendor Find(int searchID)
        {
            return _instances[searchID - 1];
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}

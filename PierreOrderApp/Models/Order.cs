using System.Collections.Generic;

namespace PierreOrderApp.Models
{
    public class Order
    {
        public string Details { get; set; }
        public int ID { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string details)
        {
            Details = details;
            _instances.Add(this);
            ID = _instances.Count;
        }
        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Order Find(int searchID)
        {
            return _instances[searchID - 1];
        }
    }
}
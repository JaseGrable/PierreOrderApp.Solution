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
        }
        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
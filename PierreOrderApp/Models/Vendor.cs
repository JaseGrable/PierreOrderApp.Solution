using System.Collections.Generic;

namespace PierreOrderApp.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public int ID { get; }
        private static List<Vendor> _instances = new List<Vendor> { };

        public Vendor(string vendorName)
        {
            Name = vendorName;
            _instances.Add(this);
            ID = _instances.Count;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static List<Vendor> GetAll()
        {
            return _instances;
        }
    }
}

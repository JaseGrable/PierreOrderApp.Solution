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

        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}

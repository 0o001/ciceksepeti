using System;
using System.Collections.Generic;

namespace ciceksepeti
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Order> Orders { get; set; }
        public int minLimit { get; set; }
        public int maxLimit { get; set; }

        public Store()
        {
            Orders = new List<Order>();
        }
    }
}

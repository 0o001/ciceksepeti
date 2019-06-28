using System;
using System.Collections.Generic;

namespace ciceksepeti
{
    public class Response
    {
        public static List<Store> getStores()
        {
            List<Store> stores = new List<Store>();

            stores.Add(new Store(){ Id = 0, Name = "Kırmızı", Latitude = 41.049792, Longitude = 29.003031, minLimit = 20, maxLimit = 30 });
            stores.Add(new Store(){ Id = 1, Name = "Yeşil", Latitude = 41.069940, Longitude = 29.019250, minLimit = 35, maxLimit = 50 });
            stores.Add(new Store(){ Id = 2, Name = "Mavi", Latitude = 41.049997, Longitude = 29.026108, minLimit = 20, maxLimit = 80 });

            return stores;
        }

        public static List<Order> getOrders()
        {
            List<Order> orders = new List<Order>();

            orders.Add(new Order(){ Id = 100, Latitude = 41.078260000000, Longitude = 29.015770000000 });
            orders.Add(new Order(){ Id = 101, Latitude = 41.060780000000, Longitude = 29.010830000000 });
            orders.Add(new Order(){ Id = 102, Latitude = 41.064160000000, Longitude = 29.009970000000 });
            orders.Add(new Order(){ Id = 103, Latitude = 41.085290000000, Longitude = 29.019790000000 });
            orders.Add(new Order(){ Id = 104, Latitude = 41.041840000000, Longitude = 29.002990000000 });
            orders.Add(new Order(){ Id = 105, Latitude = 41.085500000000, Longitude = 29.008710000000 });
            orders.Add(new Order(){ Id = 106, Latitude = 41.085040000000, Longitude = 29.017570000000 });
            orders.Add(new Order(){ Id = 107, Latitude = 41.052210000000, Longitude = 29.033230000000 });
            orders.Add(new Order(){ Id = 108, Latitude = 41.081170000000, Longitude = 29.039800000000 });
            orders.Add(new Order(){ Id = 109, Latitude = 41.085960000000, Longitude = 29.033490000000 });
            orders.Add(new Order(){ Id = 110, Latitude = 41.060720000000, Longitude = 29.011340000000 });
            orders.Add(new Order(){ Id = 111, Latitude = 41.070020000000, Longitude = 29.017650000000 });
            orders.Add(new Order(){ Id = 112, Latitude = 41.080520000000, Longitude = 29.012240000000 });
            orders.Add(new Order(){ Id = 113, Latitude = 41.046150000000, Longitude = 29.012040000000 });
            orders.Add(new Order(){ Id = 114, Latitude = 41.051280000000, Longitude = 29.003100000000 });
            orders.Add(new Order(){ Id = 115, Latitude = 41.054340000000, Longitude = 29.031720000000 });
            orders.Add(new Order(){ Id = 116, Latitude = 41.078260000000, Longitude = 29.015770000000 });
            orders.Add(new Order(){ Id = 117, Latitude = 41.061770000000, Longitude = 29.037880000000 });
            orders.Add(new Order(){ Id = 118, Latitude = 41.061480000000, Longitude = 29.004810000000 });
            orders.Add(new Order(){ Id = 119, Latitude = 41.046830000000, Longitude = 29.003130000000 });
            orders.Add(new Order(){ Id = 120, Latitude = 41.042900000000, Longitude = 29.000040000000 });
            orders.Add(new Order(){ Id = 121, Latitude = 41.045500000000, Longitude = 28.999780000000 });
            orders.Add(new Order(){ Id = 122, Latitude = 41.051280000000, Longitude = 29.003100000000 });
            orders.Add(new Order(){ Id = 123, Latitude = 41.045500000000, Longitude = 28.999780000000 });
            orders.Add(new Order(){ Id = 124, Latitude = 41.059380000000, Longitude = 29.000360000000 });
            orders.Add(new Order(){ Id = 125, Latitude = 41.077080000000, Longitude = 29.031190000000 });
            orders.Add(new Order(){ Id = 126, Latitude = 41.047130000000, Longitude = 29.009110000000 });
            orders.Add(new Order(){ Id = 127, Latitude = 41.079980000000, Longitude = 29.021330000000 });
            orders.Add(new Order(){ Id = 128, Latitude = 41.064160000000, Longitude = 29.009970000000 });
            orders.Add(new Order(){ Id = 129, Latitude = 41.070920000000, Longitude = 29.042000000000 });
            orders.Add(new Order(){ Id = 130, Latitude = 41.083220000000, Longitude = 29.013630000000 });
            orders.Add(new Order(){ Id = 131, Latitude = 41.066040000000, Longitude = 29.007370000000 });
            orders.Add(new Order(){ Id = 132, Latitude = 41.080850000000, Longitude = 29.010360000000 });
            orders.Add(new Order(){ Id = 133, Latitude = 41.043780000000, Longitude = 29.009960000000 });
            orders.Add(new Order(){ Id = 134, Latitude = 41.064160000000, Longitude = 29.009970000000 });
            orders.Add(new Order(){ Id = 135, Latitude = 41.066000000000, Longitude = 29.040690000000 });
            orders.Add(new Order(){ Id = 136, Latitude = 41.086880000000, Longitude = 29.017910000000 });
            orders.Add(new Order(){ Id = 137, Latitude = 41.051750000000, Longitude = 28.990540000000 });
            orders.Add(new Order(){ Id = 138, Latitude = 41.059280000000, Longitude = 29.012050000000 });
            orders.Add(new Order(){ Id = 139, Latitude = 41.079220000000, Longitude = 29.010440000000 });
            orders.Add(new Order(){ Id = 140, Latitude = 41.054610000000, Longitude = 29.027400000000 });
            orders.Add(new Order(){ Id = 141, Latitude = 41.063070000000, Longitude = 29.010960000000 });
            orders.Add(new Order(){ Id = 142, Latitude = 41.075950000000, Longitude = 29.015770000000 });
            orders.Add(new Order(){ Id = 143, Latitude = 41.043780000000, Longitude = 29.009960000000 });
            orders.Add(new Order(){ Id = 144, Latitude = 41.067660000000, Longitude = 29.043050000000 });
            orders.Add(new Order(){ Id = 145, Latitude = 41.056190000000, Longitude = 28.999960000000 });
            orders.Add(new Order(){ Id = 146, Latitude = 41.079190000000, Longitude = 29.045160000000 });
            orders.Add(new Order(){ Id = 147, Latitude = 41.077080000000, Longitude = 29.031190000000 });
            orders.Add(new Order(){ Id = 148, Latitude = 41.057970000000, Longitude = 29.016160000000 });
            orders.Add(new Order(){ Id = 149, Latitude = 41.092640000000, Longitude = 29.018040000000 });
            orders.Add(new Order(){ Id = 150, Latitude = 41.060780000000, Longitude = 29.010830000000 });
            orders.Add(new Order(){ Id = 151, Latitude = 41.077360000000, Longitude = 29.030970000000 });
            orders.Add(new Order(){ Id = 152, Latitude = 41.048580000000, Longitude = 29.021250000000 });
            orders.Add(new Order(){ Id = 153, Latitude = 41.053072478048, Longitude = 28.987209066283 });
            orders.Add(new Order(){ Id = 154, Latitude = 41.083100000000, Longitude = 29.015150000000 });
            orders.Add(new Order(){ Id = 155, Latitude = 41.060780000000, Longitude = 29.010830000000 });
            orders.Add(new Order(){ Id = 156, Latitude = 41.052430000000, Longitude = 28.990450000000 });
            orders.Add(new Order(){ Id = 157, Latitude = 41.063710000000, Longitude = 29.010420000000 });
            orders.Add(new Order(){ Id = 158, Latitude = 41.083290000000, Longitude = 29.028520000000 });
            orders.Add(new Order(){ Id = 159, Latitude = 41.053670000000, Longitude = 28.989390000000 });
            orders.Add(new Order(){ Id = 160, Latitude = 41.076840000000, Longitude = 29.015430000000 });
            orders.Add(new Order(){ Id = 161, Latitude = 41.056950000000, Longitude = 29.012310000000 });
            orders.Add(new Order(){ Id = 162, Latitude = 41.078880000000, Longitude = 29.030180000000 });
            orders.Add(new Order(){ Id = 163, Latitude = 41.067730000000, Longitude = 29.020290000000 });
            orders.Add(new Order(){ Id = 164, Latitude = 41.063070000000, Longitude = 29.010960000000 });
            orders.Add(new Order(){ Id = 165, Latitude = 41.063070000000, Longitude = 29.010960000000 });
            orders.Add(new Order(){ Id = 166, Latitude = 41.045950000000, Longitude = 28.999860000000 });
            orders.Add(new Order(){ Id = 167, Latitude = 41.076840000000, Longitude = 29.015430000000 });
            orders.Add(new Order(){ Id = 168, Latitude = 41.061600000000, Longitude = 29.000460000000 });
            orders.Add(new Order(){ Id = 169, Latitude = 41.064380000000, Longitude = 29.001360000000 });
            orders.Add(new Order(){ Id = 170, Latitude = 41.056890000000, Longitude = 28.987130000000 });
            orders.Add(new Order(){ Id = 171, Latitude = 41.074350000000, Longitude = 29.039250000000 });
            orders.Add(new Order(){ Id = 172, Latitude = 41.051820000000, Longitude = 29.005970000000 });
            orders.Add(new Order(){ Id = 173, Latitude = 41.058420000000, Longitude = 29.007200000000 });
            orders.Add(new Order(){ Id = 174, Latitude = 41.052080000000, Longitude = 29.007210000000 });
            orders.Add(new Order(){ Id = 175, Latitude = 41.078910000000, Longitude = 29.021220000000 });
            orders.Add(new Order(){ Id = 176, Latitude = 41.057180000000, Longitude = 29.030470000000 });
            orders.Add(new Order(){ Id = 177, Latitude = 41.066040000000, Longitude = 29.007370000000 });
            orders.Add(new Order(){ Id = 178, Latitude = 41.087650000000, Longitude = 29.007350000000 });
            orders.Add(new Order(){ Id = 179, Latitude = 41.083680000000, Longitude = 29.014990000000 });
            orders.Add(new Order(){ Id = 180, Latitude = 41.089100000000, Longitude = 29.035370000000 });
            orders.Add(new Order(){ Id = 181, Latitude = 41.084760000000, Longitude = 29.013510000000 });
            orders.Add(new Order(){ Id = 182, Latitude = 41.041840000000, Longitude = 29.002990000000 });
            orders.Add(new Order(){ Id = 183, Latitude = 41.061950000000, Longitude = 29.011850000000 });
            orders.Add(new Order(){ Id = 184, Latitude = 41.053340000000, Longitude = 29.003820000000 });
            orders.Add(new Order(){ Id = 185, Latitude = 41.074380000000, Longitude = 29.018530000000 });
            orders.Add(new Order(){ Id = 186, Latitude = 41.080440000000, Longitude = 29.015540000000 });
            orders.Add(new Order(){ Id = 187, Latitude = 41.061130000000, Longitude = 28.998080000000 });
            orders.Add(new Order(){ Id = 188, Latitude = 41.060780000000, Longitude = 29.010830000000 });
            orders.Add(new Order(){ Id = 189, Latitude = 41.075650000000, Longitude = 29.020470000000 });
            orders.Add(new Order(){ Id = 190, Latitude = 41.076840000000, Longitude = 29.015430000000 });
            orders.Add(new Order(){ Id = 191, Latitude = 41.048590000000, Longitude = 29.021570000000 });
            orders.Add(new Order(){ Id = 192, Latitude = 41.066040000000, Longitude = 29.007370000000 });
            orders.Add(new Order(){ Id = 193, Latitude = 41.078476490079, Longitude = 29.009396156746 });
            orders.Add(new Order(){ Id = 194, Latitude = 41.079370000000, Longitude = 29.011590000000 });
            orders.Add(new Order(){ Id = 195, Latitude = 41.084650000000, Longitude = 29.020610000000 });
            orders.Add(new Order(){ Id = 196, Latitude = 41.066040000000, Longitude = 29.007370000000 });
            orders.Add(new Order(){ Id = 197, Latitude = 41.066440000000, Longitude = 29.004270000000 });
            orders.Add(new Order(){ Id = 198, Latitude = 41.072770000000, Longitude = 29.016660000000 });
            orders.Add(new Order(){ Id = 199, Latitude = 41.049030000000, Longitude = 29.023410000000 });

            return orders;
        }
    }
}

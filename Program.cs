using System;
using System.Collections.Generic;
using System.Linq;

namespace ciceksepeti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Store> stores = Response.getStores();
            List<Order> orders = Response.getOrders();

            foreach (Order order in orders)
            {
                Dictionary <Store, double> closetsStores = new Dictionary<Store, double>();
                
                foreach (Store store in stores)
                {
                    closetsStores.Add(store, Math.Pow((order.Latitude - store.Latitude), 2) + Math.Pow((order.Longitude - store.Longitude), 2));
                }
                
                foreach(var closetsStore in closetsStores.OrderBy( store => store.Value ))
                {
                    if(closetsStore.Key.Orders.Count < closetsStore.Key.minLimit)
                    {
                        closetsStore.Key.Orders.Add(order);
                        
                        break;
                    }
                    else
                    {
                        if(closetsStore.Key.Orders.Count < (closetsStore.Key.minLimit + (( closetsStore.Key.maxLimit - closetsStore.Key.minLimit) / 2)))
                        {
                            closetsStore.Key.Orders.Add(order);

                            break;
                        }
                    }
                }
            }

            foreach (Store store in stores)
            {
                Console.WriteLine(store.Name + " Toplam Sipariş: " + store.Orders.Count);
            }
        }
    }
}

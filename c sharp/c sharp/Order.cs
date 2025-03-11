using csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Order
    {
        public int OrderNumber { get; } = new Random().Next(1, 100000);
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public List<OrderItem> Items = new List<OrderItem>();
        public Double TotalPrice()
        {
            double price = 0;
            foreach (OrderItem item in Items)
            {
                price += item.SalePrice * item.Quan;
            }
            return price;
        }
        public Product FindItem(string p)
        {
            foreach (OrderItem p2 in Items)
            {
                if (p == p2.Item.Prod)
                {
                    return p2.Item;
                }
            }
            return null;
        }
        public override string ToString()
        {
            return String.Format($"Order#: {OrderNumber}, Date: {OrderDate}, Total: {TotalPrice()}");
        }
    }
}

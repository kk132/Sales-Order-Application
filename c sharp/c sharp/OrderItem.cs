using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class OrderItem
    {
        public Product Item { get; set; }
        public Double SalePrice { get; set; }
        public int Quan { get; set; }


        public static OrderItem operator ++(OrderItem item)
        {
            item.Quan++;
            return item;
        }
        public static OrderItem operator --(OrderItem item)
        {
            if (item.Quan > 0)
                item.Quan--;
            return item;
        }
        public static OrderItem operator +(OrderItem item, int qua)
        {
            item.Quan += qua;
            return item;
        }
        public static OrderItem operator -(OrderItem item, int qua)
        {
            if (item.Quan >= qua)
                item.Quan -= qua;
            return item;
        }
    }
}

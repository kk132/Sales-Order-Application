using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Product
    {
        public String Prod { get; set; }
        public Double Price { get; set; }
        public int Quan { get; set; }
        public override String ToString()
        {
            return string.Format($"Name: {Prod}, Price: {Price}, Quantity: {Quan}");
        }
    }
}

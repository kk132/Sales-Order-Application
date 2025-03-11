using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Customer
    {
        public String Custo { get; set; }
        public override String ToString()
        {
            return String.Format($"Name: {Custo}");
        }
    }
}

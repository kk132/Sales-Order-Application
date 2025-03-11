using csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Transaction
    {
        public Order Order { get; set; }
        public Payment payment { get; set; }
        public static Transaction operator +(Transaction t, Payment p)
        {
            t.payment = p; return t;
        }
    }
}

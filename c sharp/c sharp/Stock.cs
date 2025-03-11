using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Stock
    {
        private List<Product> Stok = new List<Product>();
        public int count()
        {
            return Stok.Count;
        }
        public void AddProduct(Product p)
        {
            int x = 0;
            foreach (Product P2 in Stok)
            {
                if (P2 == p)
                {
                    x++;
                    Console.WriteLine("This Product Is Already Here");
                }
            }
            if (x == 0)
            {
                Stok.Add(p);
                
            }

        }
        public void RemoveProduct(String p)
        {
            int x = 0;
            for (int i = Stok.Count - 1; i >= 0; i--)
            {
                if (Stok[i].Prod == p)
                {
                    x++;
                    Stok.RemoveAt(i);
                    
                }
            }
            if (x == 0)
            {
                Console.WriteLine("Not Found");
            }
        }
        public Product FindProduct(string p)
        {
            foreach (Product p2 in Stok)
            {
                if (p == p2.Prod)
                {
                    return p2;
                }
            }
            return null;
        }
        
        public void PrintStock()
        {
            Stok.ForEach(Console.WriteLine);
        }

    }
}

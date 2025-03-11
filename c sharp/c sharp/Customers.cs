using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
     internal class Customers
    {
        private List<Customer> Custs = new List<Customer>();
        public void AddCustomer(Customer c)
        {
            int x = 0;
            foreach (Customer c2 in Custs)
            {
                if (c2 == c)
                {
                    Console.WriteLine("This Customer Is Already Here");
                    x++;
                }

            }
            if (x == 0)
            {
                Custs.Add(c);
                Console.WriteLine("/\\======/\\\tDONE\t/\\======/\\\n");
            }

        }
        public String CheckCustomer(String c)
        {
            foreach (Customer c2 in Custs)
            {
                if (c2.Custo == c)
                {
                    return "here";
                }

            }
            return null;
        }
        public void RemoveCustomer(String c)
        {
            int x = 0;
            for (int i = Custs.Count - 1; i >= 0; i--)
            {
                if (Custs[i].Custo == c)
                {
                    Custs.RemoveAt(i);
                    Console.WriteLine("/\\======/\\\tDONE\t/\\======/\\\n");
                    x++;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("Not Found");
            }

        }
        public void EditCustomer(String c)
        {
            int x = 0;
            for (int i = Custs.Count - 1; i >= 0; i--)
            {
                if (Custs[i].Custo == c)
                {
                    Console.WriteLine("Founded \nEnter The New Name: ");
                    String NewName = Console.ReadLine();
                    Custs[i].Custo = NewName;
                    Console.WriteLine("/\\======/\\\tDONE\t/\\======/\\\n");
                    



                    x =1;
                }
            }
            if (x == 0)
            {
                Console.WriteLine("Not Found");
            }
            
        }
        public void PrintSCustomers()
        {
            Custs.ForEach(Console.WriteLine);
        }

    }
}

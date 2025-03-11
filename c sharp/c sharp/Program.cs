
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml.Linq;


namespace csharp
{
    class Payment
    {
        public DateTime PayTime { get; set; }
        public Double Amount { get; set; }

    }
    class Credit : Payment
    {
        public string Card { get; set; }
    }
    class Cash : Payment
    {

    }
    class Check : Payment
    {
        public string Chek { get; set; }
    }
    

    
    class Program
    {
        static void Main()
        {
            Stock stock = new Stock();
            Customers customers = new Customers();
            List<Transaction> trans = new List<Transaction>();
            Order order = new Order();
            Console.WriteLine("Welcome To Our Order Jedi\nChoose From The Folowing AND ONLY FROM THE FOLOWING :\n");
            
            while (true)
            {
                Console.WriteLine("/==========\\\t(1) Data Entry\t/==========\\\t(2) Sales Process\t/==========\\\t(3) Print\t/==========\\\n");
                Console.WriteLine("   /==================================\\\tOR (4) TO GET OUT OF HERE\t/==================================\\\n");
                String Choice = Console.ReadLine();
                switch (Choice)
                {
                    case "1":
                        bool x = true;
                        while(x)
                        {
                            Console.WriteLine("Choose Again FROM THE FOLLOWING: \n");
                            Console.WriteLine("   =^=^=^=^=^=\t(1) Customer\t=^=^=^=^=^=\t(2) Product\t=^=^=^=^=^=\t(3) Go Back\t=^=^=^=^=^=");
                            String ch1= Console.ReadLine();
                            if (ch1 == "1")
                            {
                                Console.WriteLine("Ehhh Just Choose: \n");
                                Console.WriteLine(" CUSTOMERS |=_=_=_=|  (1) Add  |=_=_=_=|  (2) Remove  |=_=_=_=|  (3) Edit  |=_=_=_=|  (4) Go Back  |=_=_=_=|\n");
                                String ch2 = Console.ReadLine();
                                if (ch2 == "1")
                                {
                                    Console.WriteLine("Enter The Name To Add: ");
                                    String nemo = Console.ReadLine();
                                    customers.AddCustomer(new Customer { Custo = nemo });

                                }
                                else if (ch2 == "2")
                                {
                                    Console.WriteLine("Enter The Name To Remove: ");
                                    String nemo2 = Console.ReadLine();
                                    customers.RemoveCustomer(nemo2);
                                }
                                else if (ch2 == "3")
                                {
                                    Console.WriteLine("Enter The Name To Edit: ");
                                    String nemo3 = Console.ReadLine();
                                    customers.EditCustomer(nemo3);
                                }
                                else if (ch2 == "4")
                                { }
                                else
                                {
                                    Console.WriteLine("Are U Idiot Or What??");
                                }
                            }
                            else if (ch1 == "2")
                            {
                                Console.WriteLine("Please Choose: \n");
                                Console.WriteLine(" PRODUCTS |=_=_=_=|  (1) Add  |=_=_=_=|  (2) Remove  |=_=_=_=|  (3) Edit  |=_=_=_=|  (4) Go Back  |=_=_=_=|\n");
                                String ch3 = Console.ReadLine();
                                if (ch3 == "1")
                                {

                                    Console.WriteLine("Enter The Product To Add: ");
                                    String nemo1 = Console.ReadLine();
                                    Console.WriteLine("Enter The Price NUMBER PLZ: ");
                                    bool a = true;
                                    Double Pric = 0;
                                    while (a)
                                    {
                                        string o = Console.ReadLine();
                                        if (Double.TryParse(o, out double d))
                                        {
                                            Pric = d;
                                            a = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("KILL YOURSELF , Try Again");
                                        }
                                    }
                                    bool g = true;
                                    Console.WriteLine("Enter The Quantity NUMBER PLZ: ");
                                    int qau = 0;
                                    while (g)
                                    {
                                        string v = Console.ReadLine();
                                        if (int.TryParse(v, out int b))
                                        {
                                            qau = b;
                                            g = false;
                                        }
                                        else
                                        {
                                            Console.WriteLine("KILL YOURSELF , Try Again");
                                        }
                                    }
                                    stock.AddProduct(new Product {Prod = nemo1,Price = Pric, Quan = qau });
                                    Console.WriteLine("/\\======/\\\tDONE\t/\\======/\\\n");



                                }
                                else if (ch3 == "2")
                                {
                                    Console.WriteLine("Enter The Name To Remove: ");
                                    String nemo2 = Console.ReadLine();
                                    stock.RemoveProduct(nemo2);

                                }
                                else if (ch3 == "3")
                                {
                                    Console.WriteLine("Enter The Name To Edit: ");
                                    String nemo3 = Console.ReadLine();
                                    if (stock.FindProduct(nemo3) == null)
                                    {
                                        Console.WriteLine("Not Found");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter The New Name: ");
                                        string z = Console.ReadLine();
                                        stock.FindProduct(nemo3).Prod = z;
                                        Console.WriteLine("Enter The New Price: ");
                                        stock.FindProduct(z).Price = Double.Parse(Console.ReadLine());
                                        Console.WriteLine("/\\======/\\\tDONE\t/\\======/\\\n");

                                    }

                                }
                                else if (ch3 == "4")
                                { }
                                else
                                {
                                    Console.WriteLine("OH COME ON!!");
                                }
                            }
                            else if (ch1 == "3")
                            {
                                x = false;
                            }
                            else if (ch1 == "4")
                            { }

                            else
                            {
                                Console.WriteLine("Make Me A Favor And Stop Being Idiot");
                            }
                        }
                        break;
                    case "2":
                        bool q = true;
                        while (q)
                        {
                            Console.WriteLine("Feel Free To Choose : |Just Kidding HURRY UP!!|\n");
                            Console.WriteLine("   =~=~=~=~=~=  (1) Add Transaction  =~=~=~=~=~=  (2) Update Order  =~=~=~=~=~=  (3) Give Me Money  =~=~=~=~=~=  (4) Go Back  =~=~=~=~=~=\n");
                            String ch2 = Console.ReadLine();
                            if (ch2 == "1")
                            {

                                Console.WriteLine("Enter Customer Name: ");
                                String Dube = Console.ReadLine();
                                if (customers.CheckCustomer(Dube) == null)
                                {
                                    Console.WriteLine("This User Doesn't Exit, Try To Add one From  Data Entry -> Customers -> Add\n");

                                }
                                else
                                {
                                    bool i = true;
                                    while (i)
                                    {
                                        Console.WriteLine("Enter Product: ");
                                        String pRo = Console.ReadLine();
                                        Product item = stock.FindProduct(pRo);
                                        if (order.FindItem(pRo) != null)
                                        {
                                            Console.WriteLine("This Item Is Already In Your Order.");
                                            break;
                                        }

                                        if (item == null)
                                        {

                                            Console.WriteLine("This Product Isn't Available Now ,Try Again Later\n");
                                            i = false;

                                        }
                                        else
                                        {
                                            Console.WriteLine("Enter Quantity: ");
                                            int qqq = int.Parse(Console.ReadLine());
                                            if (qqq <= item.Quan)
                                            {
                                                order.Items.Add(new OrderItem { Item = item, SalePrice = item.Price, Quan = qqq });
                                                Console.WriteLine("Add Another Product?? .. \n");
                                                Console.WriteLine("Yes To Continue ,,, No To GIVE ME MY MONEY\n");
                                                String f = Console.ReadLine().ToLower();
                                                if (f != "yes")
                                                {
                                                    i = false;
                                                }



                                            }
                                            else
                                            {
                                                Console.WriteLine($"Sorry, The Available Quantity Of That Item is {item.Quan}");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (ch2 == "2")
                            {
                                Console.WriteLine("Enter The Item To Update: ");
                                String str = Console.ReadLine();
                                Product product = stock.FindProduct(str);
                                Product item2 = order.FindItem(str);


                                if (item2 == null)
                                {

                                    Console.WriteLine("This Product Isn't in Your Order List\n");

                                }
                                else
                                {
                                    Console.WriteLine("Want Add Or Remove? ++ to add -- to remove");
                                    
                                    switch(Console.ReadLine())
                                    {
                                        case "++":
                                            Console.WriteLine("How Much do u Want to add?");
                                            int qq = int.Parse(Console.ReadLine());
                                            order.FindItem(str).Quan += qq;
                                            if(order.FindItem(str).Quan > product.Quan)
                                            {
                                                order.FindItem(str).Quan = product.Quan;
                                            }
                                            break;
                                        case "--":
                                            Console.WriteLine("How Much do u Want to Remove?");
                                            int qq2 = int.Parse(Console.ReadLine());
                                            order.FindItem(str).Quan -= qq2;
                                            if (order.FindItem(str).Quan < 0)
                                                order.FindItem(str).Quan = 0;
                                            break;
                                        default:
                                            Console.WriteLine("إou are not going to learn");
                                            break;

                                    }
                                    
                                }
                            }
                            else if (ch2 == "3")
                            {
                                Console.WriteLine("Enter Payment Type (Credit/Cash/Check): (FINALY SOME MONEY)");
                                string pay = Console.ReadLine().ToLower();
                                Payment payment = pay switch
                            {
                                "credit" => new Credit { Amount = order.TotalPrice(), Card = "1234-5678-9012" },
                                "cash" => new Cash { Amount = order.TotalPrice() },
                                "check" => new Check { Amount = order.TotalPrice(), Chek = "CHK123" },
                                _ => null
                            };
                                trans.Add(new Transaction { Order = order } + payment);
                            }
                            else if (ch2 == "4")
                            {
                                q = false;
                            }
                            else
                            {
                                Console.WriteLine("You Know What?\n");
                                Console.WriteLine("You Are Shame On Humanity");
                            }
                        }
                        break;
                    case "3":
                        while (true)
                        {
                            Console.WriteLine("What Do You Want To Print : (1) Customers     (2) Stock data     (3) Transactions     (4) Go Back");
                            String str3 = Console.ReadLine();
                            if (str3 == "1")
                            {
                                customers.PrintSCustomers();
                                break;
                            }
                            else if (str3 == "2")
                            {
                                stock.PrintStock();
                                break;
                            }
                            else if (str3 == "3")
                            {
                                trans.ForEach(t => Console.WriteLine(t.Order));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("I AM GONNA KILL MYSELF FOR U <3");
                            }
                        }
                            break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("OH GOOOOOD");
                        break;
                }

            }
        }
    }

}
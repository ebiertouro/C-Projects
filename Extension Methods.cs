using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{

    public static class SaleExtension
    {
        public static IEnumerable<Sale> WherePriceOver(this IEnumerable<Sale> sales, double price)
        {
            return sales.Where(sale => sale.PricePerItem > price);
        }

        public static IEnumerable<Sale> WhereQuantityOne(this IEnumerable<Sale> sales)
        {
            return sales.Where(sale => sale.Quantity == 1).OrderByDescending(sale => sale.PricePerItem);
        }

        public static IEnumerable<Sale> WhereStripedSocksNoExpeditedShipping(this IEnumerable<Sale> sales)
        {
            return sales.Where(sale => sale.Item == "Striped Socks" && !sale.ExpeditedShipping);
        }

        public static IEnumerable<string> TotalOrderOver_Addresses(this IEnumerable<Sale> sales, double cost)
        {
            return sales.Where(sale => (sale.PricePerItem * sale.Quantity) > 100).Select(sale => sale.Address);
        }

        public static IEnumerable<object> CorporateSales(this IEnumerable<Sale> sales)
        {
            return sales.Where(sale => sale.Customer.ToUpper().Contains("LLC"))
                          .Select(sale => new
                          {
                              Item = sale.Item,
                              TotalPrice = sale.PricePerItem * sale.Quantity,
                              Shipping = sale.Address + (sale.ExpeditedShipping ? " EXPEDITE" : "")
                          })
                          .OrderBy(sale => sale.TotalPrice);
        }
    }



    class MyProgram
    {
        public static void Main(string[] args)
        {
     

            Sale[] sales =
            {
                new Sale { Item = "Black Socks", Customer = "Sock Exchange LLC",
                    PricePerItem = 3.5, Quantity = 120, Address = "3711 Avenue L", ExpeditedShipping =  true},
                new Sale { Item = "White Socks", Customer = "Double Header LLC",
                    PricePerItem = 2.75, Quantity = 80, Address = "1317 East 14", ExpeditedShipping =  true},
                new Sale { Item = "Striped Socks", Customer = "Mrs. Yolanda Benitz",
                    PricePerItem = 1.66, Quantity = 1, Address = "1412 East 18", ExpeditedShipping =  false},
                new Sale { Item = "Black Socks", Customer = "Toetaly You LLC",
                    PricePerItem = 3.5, Quantity = 300, Address = "512 Madison Drive", ExpeditedShipping =  true},
                new Sale {Item = "Customized Slippers", Customer = "Mr. Dave Feuer",
                    PricePerItem = 15.79, Quantity = 2, Address = "36 Consiounstraat", ExpeditedShipping = false}
            };

            var SalesOver10 = sales.WherePriceOver(10.0);
            Console.WriteLine("Sales where price is over $10.00:\n");
            foreach (var sale in SalesOver10)
                Console.WriteLine(sale + "\n");

            var SalesOfOne = sales.WhereQuantityOne();
            Console.WriteLine("Sales where quantity is one:\n");
            foreach (var sale in SalesOfOne)
                Console.WriteLine(sale + "\n");

            var StrippedSockSales = sales.WhereStripedSocksNoExpeditedShipping();
            Console.WriteLine("Stripped sock sales (no expedited shipping):\n");
            foreach (var sale in StrippedSockSales)
                Console.WriteLine(sale + "\n");

            var Adddresses = sales.TotalOrderOver_Addresses(100);
            Console.WriteLine("Addresses of orders over $100 total:\n");
            foreach (var address in Adddresses)
                Console.WriteLine(address + "\n");

            var CorporateSales = sales.CorporateSales();
            Console.WriteLine("Corporate sales:\n");
            foreach (var sale in CorporateSales)
                Console.WriteLine(sale + "\n");

            Console.ReadLine();
        }


    }
}


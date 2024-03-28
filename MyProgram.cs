using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class MyProgram
    {
        static void Main()
        {
            Sale[] sales =
            {
                new Sale { Item = "Black Socks", Customer = "Sock Exchange",
                    PricePerItem = 3.5, Quantity = 120, ExpeditedShipping =  true},
                new Sale { Item = "White Socks", Customer = "Double Header",
                    PricePerItem = 2.75, Quantity = 80, ExpeditedShipping =  true},
                new Sale { Item = "Striped Socks", Customer = "Mrs. Yolanda Benitz",
                    PricePerItem = 1.66, Quantity = 1, ExpeditedShipping =  false},
                new Sale { Item = "Black Socks", Customer = "Toetaly You",
                    PricePerItem = 3.5, Quantity = 300, ExpeditedShipping =  true},
            };
  
            double profit1 = totalProfit(sales,
                sale => sale.ExpeditedShipping == true,
                sale => (sale.PricePerItem * sale.Quantity) + 12.95,
                (sale, profit) => Console.WriteLine($"{sale.Customer}'s order is eligible for " +
                $"expedited shipping at a profit of {profit.ToString("C")}."),
                sale => Console.WriteLine($"{sale.Customer}'s order is not eligible for expedited shipping.")
                ) ;

            Console.WriteLine();
            Console.WriteLine($"Total profit for expedited-shipping orders: {profit1.ToString("C")}");
            Console.WriteLine();

            double profit2 = totalProfit(sales,
                //determine if the customer is a private purchaser or a retailer
                sale => sale.Customer.StartsWith("Mrs") || sale.Customer.StartsWith("Mr."),
                //private purchasers must pay tax, we subtract from profit
                sale => (sale.PricePerItem * sale.Quantity) - (sale.PricePerItem * sale.Quantity * .08875),
                (sale, profit) => Console.WriteLine($"A private purchaser bought {sale.Item} for a profit of {profit.ToString("C")}"),
                sale => Console.WriteLine($"{sale.Item} was bought by a retailer.")
                );

            Console.WriteLine();
            Console.WriteLine($"Total profit for private orders: {profit2.ToString("C")}");
            Console.ReadLine();
        }

        static double totalProfit(Sale[] sales, Func<Sale, bool> toInclude, 
                                    Func<Sale, double> saleProfit, Action<Sale, double> profitAction,
                                    Action<Sale> nonIncludedAction)
        {
            double totalProfit = 0;

            foreach(Sale sale in sales)
            {
                if (toInclude(sale))
                {
                    double itemProfit = saleProfit(sale);
                    profitAction(sale, itemProfit);
                    totalProfit += itemProfit;
                }
                else
                    nonIncludedAction(sale);

            }
            return totalProfit;
        }
    }
}

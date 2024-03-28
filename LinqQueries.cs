using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class LinqQueries
    {
        static void Main()
        {
            Sale[] sales;

            var result1 = from sale in sales
                               where sale.PricePerItem > 10.0
                               select sale;

            var result2 = from sale in sales
                          where sale.Quantity == 1
                          orderby sale.PricePerItem descending
                          select sale;

            var result3 = from sale in sales
                          where sale.Item == "Tea" && sale.ExpeditedShipping == false
                          select sale;

            var result4 = from sale in sales
                          where sale.PricePerItem * sale.Quantity > 100
                          select sale.Address;

            var result5 = from sale in sales
                          where sale.Customer.ToLower().Contains("llc")
                          orderby (sale.PricePerItem * sale.Quantity) descending
                          select new
                          {
                              Item = sale.Item
                              TotalPrice = sale.PricePerItem * sale.Quantity,
                              Shipping = sale.ExpeditedShipping ? sale.Address + " EXPEDITE" : sale.Address
                          };
        }
    }
}

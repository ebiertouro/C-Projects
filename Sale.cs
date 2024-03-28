using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Sale
    {
        public String Item { get; set; }
        public String Customer { get; set; }
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }
        public String Address { get; set; }
        public bool ExpeditedShipping { get; set; }
        public override string ToString()
        {
            return $"Item: {Item}, Customer: {Customer}, PricePerItem: {PricePerItem}, Quantity: {Quantity}, Address: {Address}, ExpeditedShipping: {ExpeditedShipping}";
        }

    }
}

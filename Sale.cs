using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Sale
    {
        public string Item { get; set; }
        public string Customer { get; set; }
        public double PricePerItem { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }
        public bool ExpeditedShipping { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.BusinessLogic
{
    public class ProductOrder
    {
        public int ProductOrderID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}

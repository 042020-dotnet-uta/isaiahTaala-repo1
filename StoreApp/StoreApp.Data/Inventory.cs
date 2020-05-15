using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.Data
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public Product Product { get; set; }
        public Location Location { get; set; }
        public int Quantity { get; set; }
    }
}

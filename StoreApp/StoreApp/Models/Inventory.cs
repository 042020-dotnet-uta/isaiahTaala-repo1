using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Routing;

namespace StoreApp.Models
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Location Location { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.DataAnnotations;

namespace StoreApp.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public Location Location { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}

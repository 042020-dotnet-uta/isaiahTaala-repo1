using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StoreApp.Data
{
    public class Order
    {
        public int OrderID { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }

        [Timestamp]
        public byte[] TimeStamp { get; set; }
    }
}

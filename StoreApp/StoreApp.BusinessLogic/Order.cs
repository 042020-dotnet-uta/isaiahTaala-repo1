using System;
using System.Collections.Generic;
using System.Text;

namespace StoreApp.BusinessLogic
{
    public class Order
    {
        public int OrderID { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        public byte[] TimeStamp { get; set; }
    }
}

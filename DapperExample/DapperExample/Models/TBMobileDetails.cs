using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperExample.Models
{
    public class TBMobileDetails
    {
        public int MobileID { get; set; }
        public string MobileName { get; set; }
        public string MobileMeno { get; set; }
        public string MobileManufactured { get; set; }
        public decimal Mobileprice { get; set; }
    }
}
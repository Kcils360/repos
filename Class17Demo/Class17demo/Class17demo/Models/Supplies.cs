using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class17demo.Models
{
    public class Supplies
    {
        [Key]
        public int SupplyID { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public int Qty { get; set; }
        public int WeatherID { get; set; }
        public int AttractionID { get; set; }
        public bool IsRequired { get; set; }

    }
}

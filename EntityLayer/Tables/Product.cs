using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int TotalSales { get; set; }
        public DateTime? DateAdd { get; set; }
    }
}

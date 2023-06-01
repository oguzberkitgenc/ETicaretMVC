using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Basket
    {
        [Key]
        public int BaskedID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public decimal Sales { get; set; }
        public int  Piece { get; set; }
        public DateTime Date { get; set; }
    }
}

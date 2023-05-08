using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Tables
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string GMail { get; set; }
        public string Hotmail { get; set; }

        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Product { get; set; }
        public string Payment { get; set; }
        public string SaleNow { get; set; }
        public string Question { get; set; }
        public string Support { get; set; }
        public string News { get; set; }
        public string SubMainTitle { get; set; }
        public string SubMainDescription { get; set; }
    }
}

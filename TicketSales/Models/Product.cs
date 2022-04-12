using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSales.Models
{
     public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string place { get; set; }   

        public double Price { get; set; }

        public string Session { get; set; }

        public DateTime Tarix { get; set; }
    }
}

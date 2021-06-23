using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alia.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public int NoOfProduct { get; set; }
        public string ProductName  { get; set; }
        public decimal ProductPrice { get; set; }
        public int Qunatity { get; set; }

        public string ProductCategory { get; set; }
    }
}

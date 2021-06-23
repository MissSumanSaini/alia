using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alia.Models
{
    public class Products
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQunatity { get; set; }
        public decimal ProudctTotalAmount  { get; set; }
        public decimal Gst { get; set; }




    }
}

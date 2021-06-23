using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace alia.Models
{
    public class ForgetPassword
    {
        public int Customerid { get; set; }
        public string Email { get; set; }
        public int ResetToken { get; set; }
       

    }
}
 
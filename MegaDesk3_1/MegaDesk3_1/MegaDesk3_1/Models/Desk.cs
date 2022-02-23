using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk3_1.Models
{
    public class Desk
    {

        [Key]
        public int Id { get; set; }

        public double quotePrice;
        public int area { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk3_1.Models
{
    public class DeskQuote
    {
        public int Id { get; set; }

        public Desk Desk { get; set; }


        [Display(Name="First Name")]
        [Required]
        public string CustFirstName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Quote Date")]
        public DateTime QuoteDate { get; set; }

        [Range(24,96)]
        public int Width { get; set; }

        [Range(12,48)]
        public int Depth { get; set; }

        [Display(Name="Number of Drawers")]
        [Range(0,7)]
        public int NumOfDrawers { get; set; }

        [Display(Name ="Desktop Material")]
        [Required]
        public string DeskMaterial { get; set; }

        [Display(Name = "Shipping Options")]
        [Required]
        public int ShipDays { get; set; }

        [Display(Name ="Quote Total")]
        [DataType(DataType.Currency)]
        public double QuoteTotal { get; set; }



        //set constants
        public const int BASE_PRICE = 200;
        public const int MIN_SIZE = 1000;
        public const int MAX_SIZE = 2000;
        public const int PRICE_PER_AREA = 1;
        public const int PRICE_PER_DRAWER = 50;
        public List<DeskQuote> deskQuotes = new List<DeskQuote>();

        //set ShippingOptions
        public enum ShippingOptions
        {
            [Display(Name = "Standard 14 day")]
            Standard = 14,
            [Display(Name = "3 Day")]
            ThreeDay = 3,
            [Display(Name = "5 Day")]
            FiveDay =5,
            [Display(Name = "7 Day")]
            SevenDay = 7
        }

    }
}

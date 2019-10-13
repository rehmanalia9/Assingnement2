using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assingment_Test_2.Models
{
    public partial class Items
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "please enter Catagory required!!.")]
        public string CatagoryId { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        public string Descripition { get; set; }
        public string Quality { get; set; }
        public decimal? CostPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public byte[] MainImage { get; set; }
        public string ItemCode { get; set; }
        public string MainColour { get; set; }
        public string Status { get; set; }
    }
}

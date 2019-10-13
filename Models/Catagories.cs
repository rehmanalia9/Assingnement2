using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assingment_Test_2.Models
{
    public partial class Catagories
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        [MaxLength(20)]
        public string Name { get; set; }
        public byte[] Picture { get; set; }
        public string Status { get; set; }
    }
}

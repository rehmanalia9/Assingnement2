using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assingment_Test_2.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        [MaxLength(15)]
        [MinLength(3)]
        public string Username { get; set; }
        public string DisplayName { get; set; }
        [Required(ErrorMessage = "Please enter your Password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your Email.")]
        public string Email { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public byte[] ProfilePicture { get; set; }
        public DateTime? RegisterDate { get; set; }
    }
}

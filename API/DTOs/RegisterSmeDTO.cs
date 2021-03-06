using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterSmeDTO
    {
        [Required]
        public String Username { get; set; }
        [Required]
         public string CompName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]  
        public string RepresentName { get; set; }

        [Required]
        public string RepresentLName { get; set; }

        [Required]
        public int RepresentPhone { get; set; }

        public string SocialLink { get; set; }



    }
}
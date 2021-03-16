

namespace back.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    public class RegisterNewUserViewModel
    {
        [Required]
        [Display(Name ="Primert Nombre")]
        public string FirtsName { get; set; }

        [Required]
        [Display(Name ="Apellido")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string Confirm { get; set; }



    }
}

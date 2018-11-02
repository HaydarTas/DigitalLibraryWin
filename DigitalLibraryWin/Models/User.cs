using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace DigitalLibraryWin.Models
{
    public class User
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required]
        [Display(Name = "Brugernavn")]
        public String Username { get; set; }

        [Required]
        [Display(Name = "Kode")]
        public String Password { get; set; }

        [Required(ErrorMessage = "Confirmation Password is required")]
        [Display(Name = "Bekræft Kode")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match")]
        public string ConfirmPassword { get; set; }

        //[Required]
        //[Display(Name = "Group")]
        //public List <UserGroup>Group { get; set; }

        
        //public String type { get; set; }
        //public DateTime Create_date { get; set; }

    }

    public class UserGroup
    {
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "isInvolved")]
        public bool isInVolved { get; set; }

    }
}
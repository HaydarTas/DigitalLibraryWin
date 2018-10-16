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
       
        //public int userId { get; set; }

        [Required]
        [Display(Name = "Email")]
        public String Email { get; set; }

        [Required]
        [Display(Name = "Username")]
        public String Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        public String Password { get; set; }

        [Required]
        [Display(Name = "Group")]
        public List <UserGroup>Group { get; set; }

        
        //public String type { get; set; }
        //public DateTime date { get; set; }

    }

    public class UserGroup
    {
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "isInvolved")]
        public bool isInVolved { get; set; }

    }
}
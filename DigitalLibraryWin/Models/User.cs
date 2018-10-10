using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalLibraryWin.Models
{
    public class User
    {

        public int userId { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public String type { get; set; }
        public DateTime date { get; set; }

    }

}
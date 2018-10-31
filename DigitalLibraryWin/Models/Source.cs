using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DigitalLibraryWin.Models
{
    public class Source
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public String Language { get; set; }
        public int Length { get; set; }
        public String Format { get; set; }
        public Array Tags { get; set; }
    }
}
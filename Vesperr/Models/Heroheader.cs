using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Heroheader
    {
        public int id { get; set; }
        [Required]
        public string  sitename { get; set; }
        [Required]
        public string photo { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string comment { get; set; }
    }
}

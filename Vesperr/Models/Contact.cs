using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vesperr.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string description { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

    }
}

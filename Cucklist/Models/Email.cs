using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cucklist.Models
{
    public class Email
    {

        public int EmailId { get; set; }
        public string Address { get; set; }

        public Email(string address)
        {

            Address = address;

        }



    }
}

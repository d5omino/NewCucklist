using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Cucklist.Models
{
    public class Email:MailAddress
    {
        public Email(string address) : base(address)
        {
        }

        public Email(string address, string displayName) : base(address, displayName)
        {
        }

        public Email(string address, string displayName, Encoding displayNameEncoding) : base(address, displayName, displayNameEncoding)
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmailId { get; set; }
        public bool IsPrimary { get; set; }
        public bool ContactOk { get; set; }
    }
}

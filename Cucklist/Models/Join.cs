using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cucklist.Models
{
    public class Join
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JoinId { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Phone { get; set; }
        public bool Contact { get; set; }
        public bool Notify { get; set; }
        public Email Email { get; set; }

        public Join(string givenname, string familyname, Email address)
        {
            JoinId = this.JoinId;
            GivenName = givenname;
            FamilyName = familyname;
            Email = address;

        }

        public Join()
        {
            JoinId = this.JoinId;

        }


    }
}

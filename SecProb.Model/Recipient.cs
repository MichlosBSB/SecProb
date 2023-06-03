using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecProb.Model
{
    public class Recipient
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "{0} size should be between {2} and {1}" )]
        public string ColabName { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid e-mail")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        public bool Active { get; set; } = true;

        [ForeignKey(nameof(EmployeeRole))]
        public int EmployeeRoleId { get; set; }
        public virtual EmployeeRole EmployeeRole { get; set; }

        public ICollection<ListSentRecipient> ListSentRecipients { get; set; } = new List<ListSentRecipient>();

        public Recipient()
        {
        }

        public Recipient(int id, string colabName, string mail, bool active, EmployeeRole employeeRole)
        {
            Id = id;
            ColabName = colabName;
            Mail = mail;
            Active = active;
            EmployeeRole = employeeRole;
        }

        

    }
}

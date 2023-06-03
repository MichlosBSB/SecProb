using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecProb.Model
{
    public class ListSentRecipient
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Sent))]
        public int SentId { get; set; }
        public virtual Sent Sent { get; set; }

        [ForeignKey(nameof(Recipient))]
        public int RecipientId { get; set; }
        public virtual Recipient Recipient { get; set; }
    }
}

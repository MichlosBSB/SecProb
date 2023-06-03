using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecProb.Model
{
    public class Sent
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ModelMail))]
        public int ModelId { get; set; }
        public virtual ModelMail ModelMail { get; set; }
        
        [ForeignKey(nameof(Recipient))]
        public int RecipentId { get; set; }
        public virtual Recipient Recipient { get; set; }
        public DateTime DateSent { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecProb.Model
{
    public class Sent
    {
        [Key]
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int RecipentId { get; set; }
        public DateTime DateSent { get; set; }


    }
}

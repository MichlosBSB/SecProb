using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecProb.Model
{
    public class ModelMail
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Subject { get; set; }
        [StringLength(5000, MinimumLength = 10, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Content { get; set; }
        public bool Used { get; set; } = false;
        public DateTime DateUsed { get; set; }
        public int ExpireTime { get; set; }
        public DateTime DateExpired { get; set; }



    }
}

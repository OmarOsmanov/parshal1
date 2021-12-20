using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class SendMessage
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Fullname { get; set; }
        [MaxLength(100)]
        public string Mail { get; set; }
        [MaxLength(100)]
        public string Subject { get; set; }
        [Column(TypeName = "ntext")]
        public string Yourmessage { get; set; }
    }
}

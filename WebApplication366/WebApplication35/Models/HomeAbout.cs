using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class HomeAbout
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Tittle { get; set; }
        [Column(TypeName = "ntext")]
        public string Context { get; set; }
    }
}

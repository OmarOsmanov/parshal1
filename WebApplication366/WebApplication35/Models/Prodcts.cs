using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Prodcts
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string name { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(50)]
        public string Tittle { get; set; }
        
        public decimal Price { get; set; }
        [MaxLength(250)]
        public string Context { get; set; }


        [ForeignKey("Rewies")]
        public int RewiesId { get; set; }
        public Rewies Rewies { get; set; }
    }
}

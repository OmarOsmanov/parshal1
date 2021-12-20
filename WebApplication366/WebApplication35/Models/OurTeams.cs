using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class OurTeams
    {
        [Key]

        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        [MaxLength(50)]
        public string Image { get; set; }
        [MaxLength(50)]
        public DateTime CreatDate { get; set; }

        [ForeignKey("OurSosial")]
        public int OurSosialId { get; set; }
        public OurSosial OurSosial { get; set; }

        [Column(TypeName = "ntext")]
        public string Context { get; set; }
    }
}

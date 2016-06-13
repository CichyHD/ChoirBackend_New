using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChoirSGGW.Entities.Models
{
    [Table("Concerts")]
    public class Concert : Event
    {
        public Concert()
        {
            Members = new List<User>();
            Photos = new List<Photo>();
        }

        [MaxLength(150)]
        public string ConcertUrl { get; set; }
        [Column("Members")]
        public List<User> Members { get; set; }
        [Column("Photos")]
        public List<Photo> Photos { get; set; }
        [Column("ClotheType")]
        public ClotheTypes ClotheType { get; set; }
    }
}

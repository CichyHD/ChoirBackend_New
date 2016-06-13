using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models
{
    [Table("Topicalitys")]
    public class Topicality : Event
    {
        public Topicality()
        {
            Photos = new List<Photo>();
        }

        [Column("Photos")]
        public virtual List<Photo> Photos { get; set; }
        [Column("Types")]
        public virtual TopicalityType Type { get; set; }
    }
}

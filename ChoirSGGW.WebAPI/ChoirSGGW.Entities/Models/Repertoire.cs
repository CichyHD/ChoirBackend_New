using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models.Types;
using ChoirSGGW.Entities.Models.BasicModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models
{
    [Table("Repertoires")]
    public class Repertoire : VisibilityModel
    {
        [Required, MaxLength(50)]
        public string SongName { get; set; }
        [Column("SongType")]
        public virtual SongsTypes SongType { get; set; }
    }
}

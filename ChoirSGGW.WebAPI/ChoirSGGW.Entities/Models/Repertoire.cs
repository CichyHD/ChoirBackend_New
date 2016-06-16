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
        public string Artist { get; set; }

        public string Description { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        public string Genre { get; set; }

        public string Album { get; set; }

        public string Length { get; set; }

        [Column("SongType")]
        public virtual SongsTypes SongType { get; set; }
    }
}

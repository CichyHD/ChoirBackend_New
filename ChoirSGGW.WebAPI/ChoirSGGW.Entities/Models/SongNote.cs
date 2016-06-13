using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models
{
    [Table("SongNotes")]
    public class SongNote : VisibilityModel
    {
        public SongNote()
        {
            Notes = new List<Photo>();
        }

        [Required, MaxLength(100)]
        public string SongName { get; set; }
        public virtual Photo MainPhoto { get; set; }
        [Column("Notes")]
        public virtual List<Photo> Notes{ get; set; }
    }
}

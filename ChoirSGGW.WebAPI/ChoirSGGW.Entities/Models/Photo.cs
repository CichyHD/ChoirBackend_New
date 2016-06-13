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
    [Table("Photos")]
    public class Photo : VisibilityModel
    {
        [Required, MaxLength(100)]
        public string PhotoName { get; set; } //photo name with extension. For example rower.jpg / samochod.png
        [MaxLength(500)]
        public string PhotoDescription { get; set; }
        public byte[] PhotoFileByte { get; set; }
    }
}

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
    [Table("Video")]
    public class Video : VisibilityModel
    {
        [Required, MaxLength(100)]
        public string VideoName { get; set; } //video name
        [MaxLength(500)]
        public string VideoDescription { get; set; }
        [MaxLength(150)]
        public string LinkToVideo { get; set; }
    }
}

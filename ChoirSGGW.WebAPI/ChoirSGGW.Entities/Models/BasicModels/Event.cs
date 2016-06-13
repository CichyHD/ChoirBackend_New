using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models.BasicModels
{
    public abstract class Event : VisibilityModel
    {
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        public virtual Photo MainPhoto { get; set; }
        public bool IsVisibleIntoTimetable { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        [MaxLength(50)]
        public string Place { get; set; }
    }
}

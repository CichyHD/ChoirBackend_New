using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models.BasicModels
{
    public class EventDTO : VisibilityModelDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public PhotoDTO MainPhoto { get; set; }
        public bool IsVisibleIntoTimetable { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Place { get; set; }
    }
}

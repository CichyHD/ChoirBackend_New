using ChoirSGGW.WebAPI.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models
{
    public class VideoDTO : VisibilityModelDTO
    {
        public string VideoName { get; set; } //video name
        public string VideoDescription { get; set; }
        public string LinkToVideo { get; set; }
    }
}

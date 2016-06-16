using ChoirSGGW.WebAPI.Models.BasicModels;
using ChoirSGGW.WebAPI.Models.Types;
//using ChoirSGGW.Domain.Models.BasicModels;
//using ChoirSGGW.Domain.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models
{
    public class RepertoireDTO : VisibilityModelDTO
    {
        public string SongName { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Album { get; set; }
        public string Length { get; set; }
        public SongsTypeDTO SongType { get; set; }
    }
}

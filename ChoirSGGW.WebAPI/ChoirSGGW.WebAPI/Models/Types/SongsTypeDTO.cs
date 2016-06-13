using ChoirSGGW.WebAPI.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models.Types
{
    public class SongsTypeDTO : BasicModelDTO
    {
        public SongsTypeDTO(string songType)
        {
            this.SongType = songType;
        }

        public string SongType { get; set; }
    }
}

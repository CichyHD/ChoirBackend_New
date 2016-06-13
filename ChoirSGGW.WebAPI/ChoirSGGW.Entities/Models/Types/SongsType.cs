using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models.Types
{
    [Table("SongsTypes")]
    public class SongsTypes : BasicModel
    {
        public SongsTypes(string songType)
        {
            this.SongType = songType;
        }

        [MaxLength(50)]
        public string SongType { get; set; }
    }
}

using ChoirSGGW.WebAPI.Models.BasicModels;
using ChoirSGGW.WebAPI.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models
{
    public class SampleDTO : VisibilityModelDTO
    {
        public ClotheTypesDTO ClotheType { get; set; }
        public int IsOpenToAll { get; set; }
    }
}

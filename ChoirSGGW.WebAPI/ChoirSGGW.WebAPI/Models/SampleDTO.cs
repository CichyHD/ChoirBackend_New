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
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public ClotheTypesDTO ClotheType { get; set; }
        public int IsOpenToAll { get; set; }
    }
}

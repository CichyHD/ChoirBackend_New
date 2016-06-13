using ChoirSGGW.WebAPI.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models.Types
{
    public class ClotheTypesDTO : BasicModelDTO
    {
        public ClotheTypesDTO(string clotheType)
        {
            this.ClotheType = clotheType;
        }

        public string ClotheType { get; set; }
    }
}

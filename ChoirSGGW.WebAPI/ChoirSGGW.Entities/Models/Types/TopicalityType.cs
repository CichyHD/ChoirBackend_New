using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Content.Enums;
using ChoirSGGW.Entities.Models.BasicModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models.Types
{
    [Table("TopicalityTypes")]
    public class TopicalityType : BasicModel
    {
        public TopicalityTypesEnums Type { get; set; }
    }
}

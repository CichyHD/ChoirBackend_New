using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Entities.Models.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models
{
    [Table("Samples")]
    public class Sample : VisibilityModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        [Column("ClotheType")]
        public virtual ClotheTypes ClotheType { get; set; }
        public int IsOpenToAll { get; set; }
    }
}

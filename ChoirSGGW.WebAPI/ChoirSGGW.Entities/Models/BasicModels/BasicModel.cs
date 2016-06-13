using ChoirSGGW.Entities.Models.BasicModels.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models.BasicModels
{
    public abstract class BasicModel : IBasicModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime UpdatedDate { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public virtual User UpdatedBy { get; set; }
    }
}

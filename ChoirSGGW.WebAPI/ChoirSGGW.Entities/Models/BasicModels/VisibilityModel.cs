using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models.BasicModels
{
    public abstract class VisibilityModel : BasicModel
    {
        public bool IsApproved { get; set; }
        //[Required]
        public virtual User UserWhoCreated { get; set; }
        //[Required]
        public virtual User UserWhoApproved { get; set; }
    }
}

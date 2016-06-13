using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models.BasicModels
{
    public class VisibilityModelDTO : BasicModelDTO
    {
        public bool IsApproved { get; set; }
        public UserDTO UserWhoCreated { get; set; }
        public UserDTO UserWhoApproved { get; set; }
    }
}

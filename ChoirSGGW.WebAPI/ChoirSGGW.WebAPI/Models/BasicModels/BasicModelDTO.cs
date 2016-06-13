using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.WebAPI.Models.BasicModels
{
    public class BasicModelDTO
    {
        public int Id { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public UserDTO UpdatedBy { get; set; }
    }
}

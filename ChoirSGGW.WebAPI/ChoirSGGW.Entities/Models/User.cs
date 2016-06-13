using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Entities.Models
{
    [Table("Users")]
    public class User : BasicModel
    {
        public int UserName { get; set; }
    }
}

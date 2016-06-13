using ChoirSGGW.Entities.Models.BasicModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChoirSGGW.Content.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoirSGGW.Entities.Models.Types
{
    [Table("UserTypes")]
    public class UserTypes : BasicModel
    {
        public UserTypeEnum UserType { get; set; }
    }
}

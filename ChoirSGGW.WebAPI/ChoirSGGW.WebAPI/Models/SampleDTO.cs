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
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string description { get; set; }

        public string date = "2016-03-03";
        public string time = "18:30";
        public string creator = "admin";

        public ClotheTypesDTO clotheType { get; set; }
        public int isOpenToAll { get; set; }
    }
}

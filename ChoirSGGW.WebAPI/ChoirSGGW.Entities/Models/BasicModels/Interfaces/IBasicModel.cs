using System;
namespace ChoirSGGW.Entities.Models.BasicModels.Interfaces
{
    public interface IBasicModel
    {
        DateTime CreatedDate { get; set; }
        int Id { get; set; }
        ChoirSGGW.Entities.Models.User UpdatedBy { get; set; }
        DateTime UpdatedDate { get; set; }
    }
}

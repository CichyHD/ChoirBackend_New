using System;
namespace ChoirSGGW.Domain.Services.Generic
{
    public interface IGenericService<T>
     where T : ChoirSGGW.Entities.Models.BasicModels.BasicModel
    {
        void Create(T entity);
        void Delete(T entity);
        System.Collections.Generic.IEnumerable<T> GetAll();
        void Update(T entity);
    }
}

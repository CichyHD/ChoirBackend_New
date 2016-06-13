using System;
namespace ChoirSGGW.DataAccess.UnitOfWorkk
{
    public interface IUnitOfWork
    {
        int Commit();
        void Dispose();
    }
}

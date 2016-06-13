using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.DataAccess.UnitOfWorkk;
using ChoirSGGW.Domain.Services.Generic;
using ChoirSGGW.Domain.Services.Interfaces;
using ChoirSGGW.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services
{
    public class RepertoireService : GenericService<Repertoire>, IRepertoireService
    {
        readonly IRepertoireRepository repertoireRepository;

        public RepertoireService(IUnitOfWork unitOfWork, IRepertoireRepository repertoireRepository)
            :base(unitOfWork, repertoireRepository)
        {
            this.repertoireRepository = repertoireRepository;
        }
    }
}

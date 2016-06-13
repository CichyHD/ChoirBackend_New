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
    public class TopicalityService : GenericService<Topicality>, ITopicalityService
    {
        readonly ITopicalityRepository topicalityRepository;

        public TopicalityService(IUnitOfWork unitOfWork, ITopicalityRepository topicalityRepository)
            :base(unitOfWork, topicalityRepository)
        {
            this.topicalityRepository = topicalityRepository;
        }
    }
}

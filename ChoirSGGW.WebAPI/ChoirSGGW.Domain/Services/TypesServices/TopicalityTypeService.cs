using ChoirSGGW.DataAccess.Repositories.TypesRepository.Interfaces;
using ChoirSGGW.Domain.Services.TypesServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.Domain.Services.TypesServices
{
    public class TopicalityTypeService : ITopicalityTypeService
    {
        readonly ITopicalityTypeRepository topicalityTypeRepository;

        public TopicalityTypeService(ITopicalityTypeRepository topicalityTypeRepository)
        {
            this.topicalityTypeRepository = topicalityTypeRepository;
        }
    }
}

﻿using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.Generic;
using ChoirSGGW.DataAccess.Repositories.TypesRepository.Interfaces;
using ChoirSGGW.Entities.Models.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoirSGGW.DataAccess.Repositories.TypesRepository
{
    public class TopicalityTypeRepository : GenericRepository<TopicalityType>, ITopicalityTypeRepository
    {
        public TopicalityTypeRepository(IChoirContext context)
            : base(context)
        {
        }
    }
}

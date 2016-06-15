using ChoirSGGW.DataAccess.Context;
using ChoirSGGW.DataAccess.Repositories.Generic;
using ChoirSGGW.DataAccess.Repositories.Interfaces;
using ChoirSGGW.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ChoirSGGW.DataAccess.Repositories
{
    public class RepertoireRepository : GenericRepository<Repertoire>, IRepertoireRepository
    {
        public RepertoireRepository(IChoirContext context)
            : base(context)
        {
        }
    }
}

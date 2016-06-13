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

namespace ChoirSGGW.DataAccess.Repositories
{
    public class AchievementRepository : GenericRepository<Achievement>, IAchievementRepository
    {
        public AchievementRepository(IChoirContext context)
            : base(context)
        {
        }
    }
}

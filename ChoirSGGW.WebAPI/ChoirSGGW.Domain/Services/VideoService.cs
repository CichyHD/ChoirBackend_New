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
    public class VideoService : GenericService<Video>, IVideoService
    {
        readonly IVideoRepository videoRepository;

        public VideoService(IUnitOfWork unitOfWork, IVideoRepository videoRepository)
            :base(unitOfWork, videoRepository)
        {
            this.videoRepository = videoRepository;
        }
    }
}

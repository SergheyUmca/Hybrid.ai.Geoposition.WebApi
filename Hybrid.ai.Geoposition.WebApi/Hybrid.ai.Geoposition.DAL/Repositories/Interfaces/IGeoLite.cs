﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hybrid.ai.Geoposition.DAL.Entities;
using static Hybrid.ai.Geoposition.Common.Models.BaseModels.Response.AppResponse;

namespace Hybrid.ai.Geoposition.DAL.Repositories.Interfaces
{
    public interface IGeoLite
    {
        Task<Response<IpV4GeoLiteInformationEntity>> Get(string md5Hash, string network);
        
        Task<Response<List<IpV4GeoLiteInformationEntity>>> GetList(string md5Hash);

        Task<Response<bool>> CheckHash(string md5Hash);

        Task<Response<Dictionary<Guid, IpV4GeoLiteInformationEntity>>> CreateRange(
            List<IpV4GeoLiteInformationEntity> directoryEntitiesList);

        Task<Response> Update(IpV4GeoLiteInformationEntity entity);
    }
}
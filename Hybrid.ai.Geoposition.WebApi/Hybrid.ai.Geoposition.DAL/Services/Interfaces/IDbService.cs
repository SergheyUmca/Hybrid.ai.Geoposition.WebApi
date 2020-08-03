using System;
using Hybrid.ai.Geoposition.DAL.Repositories.Interfaces;
using Hybrid.ai.Geoposition.DAL.Services.Implementation;

namespace Hybrid.ai.Geoposition.DAL.Services.Interfaces
{
     public interface IDbService : IDisposable
    {
        DbService DbServiceInstance { get; }
        
        IGeoLiteRepository GeoLite { get; }
    }
}
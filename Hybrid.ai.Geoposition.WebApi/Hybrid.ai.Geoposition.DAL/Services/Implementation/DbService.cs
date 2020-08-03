using System;
using Hybrid.ai.Geoposition.DAL.Context;
using Hybrid.ai.Geoposition.DAL.Repositories.Implementation;
using Hybrid.ai.Geoposition.DAL.Repositories.Interfaces;
using Hybrid.ai.Geoposition.DAL.Services.Interfaces;

namespace Hybrid.ai.Geoposition.DAL.Services.Implementation
{
    public class DbService : IDbService
    {
        private readonly BaseContext _db;
        private readonly Lazy<DbService> _lazyDbService;
        private readonly object _locker = new object();

        private IGeoLiteRepository _geoLite;

        public DbService(BaseContext db)
        {
            lock (_locker)
            {
                _db = db;
                _lazyDbService = new Lazy<DbService>(() => new DbService(_db));
            }
        }

        public DbService DbServiceInstance => _lazyDbService.Value;
     


        public IGeoLiteRepository GeoLite => _geoLite ?? (_geoLite = new GeoLiteRepository(_db));

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
using System;
using System.Threading.Tasks;
using Hybrid.ai.Geoposition.BLL.Handlers.Interfaces;
using Hybrid.ai.Geoposition.BLL.Models.ResponseModel;
using Hybrid.ai.Geoposition.Common.Models.BaseModels;
using Hybrid.ai.Geoposition.DAL.Context;
using Hybrid.ai.Geoposition.DAL.Services.Implementation;
using Hybrid.ai.Geoposition.DAL.Services.Interfaces;
using LukeSkywalker.IPNetwork;
using static Hybrid.ai.Geoposition.Common.Models.Constants.ErrorMessages;

namespace Hybrid.ai.Geoposition.BLL.Handlers.Implementation
{
    public class InformationHandler : IInformationHandler
    {
        private readonly BaseContext _db;
        
        public InformationHandler(BaseContext context)
        {
            _db = context;
        }
        
        
        public Task<AppResponse.Response<GeoPositionResponse>> GetGeoPosition(string ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress))
                throw new CustomException(ResponseCodes.INVALID_PARAMETER, EmptyIpAddressHaveBeenPassedErrorMessage);

            try
            {
                using (IDbService dbService = new DbService(_db).DbServiceInstance)
                {
                    var getInformation = await dbService.GeoLite.Get()
                }
                

                var g = IPNetwork.Parse(ipAddress, 8);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            throw new System.NotImplementedException();
        }
    }
}
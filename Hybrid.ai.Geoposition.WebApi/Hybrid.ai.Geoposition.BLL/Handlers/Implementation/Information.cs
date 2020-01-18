using System;
using System.Threading.Tasks;
using Hybrid.ai.Geoposition.BLL.Handlers.Interfaces;
using Hybrid.ai.Geoposition.Common.Models.BaseModels;
using Hybrid.ai.Geoposition.Common.Models.ResponseModel;
using static Hybrid.ai.Geoposition.Common.Models.Constants.ErrorMessages;

namespace Hybrid.ai.Geoposition.BLL.Handlers.Implementation
{
    public class Information : IInformation
    {
        public Task<Response.AppResponse.Response<GeoPosition>> GetGeoPosition(string ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress))
                throw new CustomException(ResponseCodes.INVALID_PARAMETER, EmptyIpAddressHaveBeenPassedErrorMessage);

            try
            {

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
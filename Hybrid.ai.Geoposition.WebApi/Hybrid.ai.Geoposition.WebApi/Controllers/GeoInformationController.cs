using System.Linq;
using System.Threading.Tasks;
using Hybrid.ai.Geoposition.BLL.Handlers.Implementation;
using Hybrid.ai.Geoposition.Common.Models.BaseModels;
using Hybrid.ai.Geoposition.WebApi.Models.Response;
using Microsoft.AspNetCore.Mvc;
using static Hybrid.ai.Geoposition.Common.Models.BaseModels.AppResponse;

namespace Hybrid.ai.Geoposition.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoInformationController : BaseController
    {
        [HttpGet("GetGeoPosition")]
        public async Task<Response<GeoPositionResponse>> GetGeoPosition()
        {

            var getIp = GetIpAddress();
            var getInformation = await new InformationHandler().GetGeoPosition(getIp);
            
            if(getInformation.ResultCode != ResponseCodes.SUCCESS)
                throw new CustomException(getInformation.ResultCode, getInformation.Errors.FirstOrDefault()?.ResultMessage);
                
            return new Response<GeoPositionResponse>(new GeoPositionResponse
            {
                CityName = getInformation.Data.CityName,
                CountryCode = getInformation.Data.CountryCode,
                CountryName = getInformation.Data.CountryName,
                IpAddress = getInformation.Data.IpAddress
            });
        }
    }
}
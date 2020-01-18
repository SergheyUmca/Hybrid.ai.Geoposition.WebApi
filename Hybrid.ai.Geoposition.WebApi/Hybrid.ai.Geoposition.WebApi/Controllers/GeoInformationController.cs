using System.Threading.Tasks;
using Hybrid.ai.Geoposition.BLL.Handlers.Interfaces;
using Hybrid.ai.Geoposition.Common.Models.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using static Hybrid.ai.Geoposition.Common.Models.BaseModels.Response.AppResponse;

namespace Hybrid.ai.Geoposition.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoInformationController : BaseController
    {
        [HttpGet("GetGeoPosition")]
        public async Task<Response<GeoPosition>> GetGeoPosition([FromServices]IInformation handler)
        {

            var getIp = GetIpAddress();
            var getInformation = await handler.GetGeoPosition(getIp);
            
            return getInformation;
        }
    }
}
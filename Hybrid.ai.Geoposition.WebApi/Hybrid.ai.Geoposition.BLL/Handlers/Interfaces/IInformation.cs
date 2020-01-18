using System.Threading.Tasks;
using Hybrid.ai.Geoposition.Common.Models.ResponseModel;
using static Hybrid.ai.Geoposition.Common.Models.BaseModels.Response.AppResponse;

namespace Hybrid.ai.Geoposition.BLL.Handlers.Interfaces
{
    public interface IInformation
    {
        Task<Response<GeoPosition>> GetGeoPosition(string ipAddress);
    }
}
using System.Threading.Tasks;
using Hybrid.ai.Geoposition.BLL.Models.ResponseModel;
using static Hybrid.ai.Geoposition.Common.Models.BaseModels.AppResponse;

namespace Hybrid.ai.Geoposition.BLL.Handlers.Interfaces
{
    public interface IInformationHandler
    {
        Task<Response<GeoPositionResponse>> GetGeoPosition(string ipAddress);
    }
}
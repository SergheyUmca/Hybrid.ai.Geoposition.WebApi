using System;
using Microsoft.AspNetCore.Mvc;

namespace Hybrid.ai.Geoposition.WebApi.Controllers
{
    public class BaseController : Controller
    {
        protected string GetIpAddress() => string.IsNullOrEmpty(Request.HttpContext.Connection.RemoteIpAddress?.ToString()) ? string.Empty : Request.HttpContext.Connection.RemoteIpAddress?.ToString();
    }
}
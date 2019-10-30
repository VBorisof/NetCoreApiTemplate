using System.Net;
using Microsoft.AspNetCore.Mvc;
using NetCoreApiTemplate.Services.Shared;

namespace NetCoreApiTemplate.Extensions
{
    public static class ControllerBaseExtensions
    {   
        public static ActionResult FromServiceOperationResult<TData>(
            this ControllerBase controllerBase, ServiceOperationResult<TData> result
        )
        {
            switch (result.StatusCode)
            {
                case HttpStatusCode.OK:
                    return controllerBase.Ok(result.Data);
                
                case HttpStatusCode.Accepted:
                    return controllerBase.Accepted();
                
                case HttpStatusCode.Unauthorized:
                    return controllerBase.Unauthorized();
                
                case HttpStatusCode.NotFound:
                    return controllerBase.NotFound(result.Errors);
                
                case HttpStatusCode.Conflict:
                    return controllerBase.Conflict(result.Errors);
                
                case HttpStatusCode.UnprocessableEntity:
                    return controllerBase.UnprocessableEntity(result.Errors);
                
                case HttpStatusCode.NotImplemented:
                    return controllerBase.StatusCode((int) result.StatusCode, result.Errors);
                
                default:
                    return controllerBase.BadRequest(result.Errors);
            }
        }
        
        public static ActionResult FromServiceOperationResult (
            this ControllerBase controllerBase, ServiceOperationResult result
        )
        {
            switch (result.StatusCode)
            {
                case HttpStatusCode.OK:
                    return controllerBase.Ok();

                case HttpStatusCode.Accepted:
                    return controllerBase.Accepted();
                
                case HttpStatusCode.Unauthorized:
                    return controllerBase.Unauthorized();
                
                case HttpStatusCode.NotFound:
                    return controllerBase.NotFound(result.Errors);
                
                case HttpStatusCode.Conflict:
                    return controllerBase.Conflict(result.Errors);
                
                case HttpStatusCode.UnprocessableEntity:
                    return controllerBase.UnprocessableEntity(result.Errors);
                
                case HttpStatusCode.NotImplemented:
                    return controllerBase.StatusCode((int) result.StatusCode, result.Errors);
                
                default:
                    return controllerBase.BadRequest(result.Errors);
            }
        }
    }
}
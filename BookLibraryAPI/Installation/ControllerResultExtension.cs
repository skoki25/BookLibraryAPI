using BookLibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Installation
{
    public static class ControllerResultExtension
    {
        public static IActionResult ServiceToActionResult<T>(this ControllerBase controllerBase, ServiceResult<T> serviceResult)
        {
            if (serviceResult.IsSuccess) 
            {
                return controllerBase.Ok(serviceResult.Data);
            }

            return controllerBase.BadRequest(serviceResult.ResultMessage);
        }

        public static async Task<IActionResult> ServiceToActionTask<T>(this ControllerBase controllerBase, ServiceResult<T> serviceResult)
        {
            if (serviceResult.IsSuccess)
            {
                return controllerBase.Ok(serviceResult.Data);
            }

            switch (serviceResult.ResultType)
            {
                case ResultType.BadRequest:
                    return controllerBase.BadRequest(serviceResult.ResultMessage);
                case ResultType.NotFound:
                    return controllerBase.NotFound(serviceResult.ResultMessage);
                case ResultType.NonContent:
                    return controllerBase.NoContent();
                default:
                    return controllerBase.BadRequest(serviceResult.ResultMessage);
            }
        }
    }
}

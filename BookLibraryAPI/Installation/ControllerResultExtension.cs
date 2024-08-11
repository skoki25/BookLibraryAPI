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

            return controllerBase.BadRequest(serviceResult.ErrorMessage);
        }
    }
}

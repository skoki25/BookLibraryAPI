using BookLibrary.Model.Messages;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookLibraryAPI.Services
{
    public class ServiceResult<T>
    {
        public bool IsSuccess { get; private set; }
        public ResultType ResultType { get; private set; }
        public ResultMessage<T> ResultMessage { get; private set; }

        public static ServiceResult<T> Success(T data)
        {
            return new ServiceResult<T> { ResultMessage = new ResultMessage<T>(true, data), IsSuccess = true, ResultType = ResultType.Ok  };
        }

        public static ServiceResult<T> Failure(string error, ResultType resultType)
        {
            return new ServiceResult<T> { IsSuccess = false, ResultMessage = new ResultMessage<T>(error), ResultType = resultType };
        }

        public async Task<IActionResult> Result()
        {
            switch (IsSuccess,ResultType)
            {
                case (true, ResultType.Ok):
                    return new OkObjectResult(ResultMessage);
                case (false, ResultType.BadRequest):
                    return new BadRequestObjectResult(ResultMessage);
                case (false, ResultType.NotFound):
                    return new NotFoundObjectResult(ResultMessage);
                case (false, ResultType.NonContent):
                    return new BadRequestObjectResult(ResultMessage);
                default:
                    return new BadRequestObjectResult(ResultMessage);
            }
        }
    }
}

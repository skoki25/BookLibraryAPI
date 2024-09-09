using BookLibrary.Model.Messages;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryAPI.Services
{
    public class ServiceResult<T>
    {
        public T Data { get; private set; }
        public bool IsSuccess { get; private set; }
        public ResultType ResultType { get; private set; }
        public ResultMessage<T> ResultMessage { get; private set; }

        public static ServiceResult<T> Success(T data)
        {
            return new ServiceResult<T> { Data = data, IsSuccess = true, ResultType = ResultType.Ok  };
        }

        public static ServiceResult<T> Failure(string error, ResultType resultType)
        {
            return new ServiceResult<T> { IsSuccess = false, ResultMessage = new ResultMessage<T>(error), ResultType = resultType };
        }

        public async Task<IActionResult> Result()
        {
            if (IsSuccess)
            {
                return new OkObjectResult(Data);
            }

            switch (ResultType)
            {
                case ResultType.BadRequest:
                    return new BadRequestObjectResult(ResultMessage);
                case ResultType.NotFound:
                    return new NotFoundResult();
                case ResultType.NonContent:
                    return new NoContentResult();
                default:
                    return new BadRequestObjectResult(ResultMessage);
            }
        }
    }
}

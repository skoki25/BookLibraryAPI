﻿using BookLibraryAPI.Data.Messages;

namespace BookLibraryAPI.Services
{
    public class ServiceResult<T>
    {
        public T Data { get; private set; }
        public bool IsSuccess { get; private set; }
        public ResultMessage<T> ResultMessage { get; private set; }

        public static ServiceResult<T> Success(T data)
        {
            return new ServiceResult<T> { Data = data, IsSuccess = true };
        }

        public static ServiceResult<T> Failure(string error)
        {
            return new ServiceResult<T> { IsSuccess = false, ResultMessage = new ResultMessage<T>(error) };
        }
    }
}

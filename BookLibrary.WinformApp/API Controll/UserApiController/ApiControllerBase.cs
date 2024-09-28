using BookLibrary.Model.Messages;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WinformApp.APIControll;

namespace BookLibrary.WinformApp.API_Controll.UserApiController
{
    public abstract class ApiControllerBase
    {
        protected readonly IApiService _apiService;

        public ApiControllerBase(IApiService apiService) 
        { 
            this._apiService = apiService;
        }
        public T GetDataFromApiCall<T>(ResultMessage<T> resultMessage)
        {
            if (resultMessage.Data == null)
            {
                return Activator.CreateInstance<T>();
            }
            else
            {
                return resultMessage.Data;
            }
        }

    }
}

using BookLibrary.Model.Messages;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinformApp.API_Controll.UserApiController
{
    public abstract class ApiControllerBase
    {
        public event Action<string> OnErrorMessage;

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

        public void ErrorMessage(string  message)
        {
            OnErrorMessage?.Invoke(message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinformApp.APIControll;

namespace BookLibrary.WinformApp.API_Controll.UserApiController
{
    public class AuthorApiController : ApiControllerBase
    {
        public AuthorApiController(IApiService apiService) : base(apiService)
        {
        }
    }
}

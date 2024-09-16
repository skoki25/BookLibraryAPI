using BookLibrary.Model.DTO;
using BookLibrary.Model.Messages;
using BookLibrary.WinformApp.API_Controll.UserApiController;
using WinformApp.APIControll;

namespace WinformApp.API_Controll.UserApiController
{
    public  class BookInfoApiController: ApiControllerBase
    {
        IApiService _apiService;

        public BookInfoApiController(IApiService apiService) 
        {
            _apiService = apiService;
        }

        public async Task<BookInfoDto?> GetBookInfoExtra(int id, string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfoExtra, id);
                ResultMessage<BookInfoDto> resultMessage = await _apiService.GetAsync<BookInfoDto>(loginEndPoint, token);
                return GetDataFromApiCall(resultMessage);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                return new BookInfoDto();
            }
        }

        public async Task<List<BookInfoDto>> GetAllBookInfo(string token)
        {
            try
            {
                string loginEndPoint = Config.Settings.GetRoute(Config.ApiBookInfo);
                ResultMessage<List<BookInfoDto>> resultMessage = await _apiService.GetAsync<List< BookInfoDto>> (loginEndPoint, token);
                return GetDataFromApiCall(resultMessage);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
                return null;
            }
        }
    }
}

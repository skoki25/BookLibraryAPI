using BookLibrary.Model.DTO;
using WinformApp.APIControll;

namespace WinformApp.API_Controll.UserApiController
{
    public  class BookInfoApiController
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
                return await _apiService.GetAsync<BookInfoDto>(loginEndPoint, token);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return null;
            }
        }
    }
}

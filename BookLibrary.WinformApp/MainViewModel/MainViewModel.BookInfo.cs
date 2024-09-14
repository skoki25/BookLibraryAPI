using BookLibrary.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformApp
{
    public partial class MainViewModel
    {
        public async Task<BookInfoDto> GetBookInfoExtra(int id)
        {
            return await _bookInfoApiController.GetBookInfoExtra(id, currentUserData.GetToken());
        }

        public async Task<List<BookInfoDto>> GetAllBookInfo()
        {
            return await _bookInfoApiController.GetAllBookInfo(currentUserData.GetToken());
        }
    }
}

using BookLibrary.WinformApp.API_Controll.UserApiController;
using WinformApp.API_Controll.UserApiController;
using WinformApp.APIControll;

namespace WinformApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IApiService apiService = new ApiService(new HttpClient());

            MainViewModel mainView = new MainViewModel(apiService);
            LoginForm loginForm = new LoginForm(mainView);
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                Application.Run(new LibraryForm(mainView, apiService));
            }
        }
    }
}
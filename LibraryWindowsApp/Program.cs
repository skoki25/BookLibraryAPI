using LibraryWindowsApp.APIControll;

namespace LibraryWindowsApp
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
            UserApiController _userApiController = new UserApiController(apiService);

            MainViewModelView mainView = new MainViewModelView(_userApiController);
            LoginForm loginForm = new LoginForm(mainView);
            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                Application.Run(new LibraryForm(mainView));
            }
        }
    }
}
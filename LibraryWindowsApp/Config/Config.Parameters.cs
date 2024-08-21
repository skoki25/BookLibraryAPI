namespace LibraryWindowsApp
{
    public partial class Config
    {
        public string Route { get; set; } = "https://localhost:7065/";

        public string GetRoute(string apiRoute)
        {
            return Route + apiRoute;
        }

        public string GetRoute(string apiRoute, int id)
        {
            return Route + apiRoute + "/" +id;
        }
    }
}

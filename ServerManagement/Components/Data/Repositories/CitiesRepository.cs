namespace ServerManagement.Components.Data.Repositories
{
    public static class CitiesRepository
    {

        private static readonly List<string> Cities = new List<string>()
        {
            "Toronto",
            "Bangalore",
            "Montreal",
            "Ottawa",
            "Calgary",
            "Halfix"

        };

        public static List<string> GetCities() { return Cities; }


    }
}

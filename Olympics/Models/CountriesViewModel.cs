namespace Olympics.Models
{
    public class CountriesViewModel
    {
        public string ActiveGame { get; set; } = "all";
        public string ActiveSport { get; set; } = "all";

        public List<Country> Countries { get; set; } = new List<Country>();
        public List<Game> Games { get; set; } = new List<Game>();
        public List<Sport> Sports { get; set; } = new List<Sport>();

        //methods to help view determin active link
        public string CheckActiveGame(string g) => g.ToLower() == ActiveGame.ToLower() ? "active" : "";
        public string CheckActiveSport(string s) => s.ToLower() == ActiveSport.ToLower() ? "active" : "";

    }
}

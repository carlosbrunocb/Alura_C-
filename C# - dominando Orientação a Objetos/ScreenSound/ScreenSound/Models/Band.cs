namespace ScreenSound.Models;

internal class Band : IAssessment
{
    private List<Album> _albums = new List<Album>();
    private List<Rating> _ratings = new List<Rating>();
    public string M_Name { get; }
    public double M_AverageRating => _ratings.Count != 0 ? _ratings.Average(e => e.M_Score) : -1;
    //public double M_AverageRating
    //{
    //    get
    //    {
    //        if (_ratings.Count == 0) return 0;
    //        else return _ratings.Average(a => a.M_Score);
    //    }
    //}
    public List<Album> Albums => _albums;
    public string M_Summary { get; set; }
    public Band(string name)
    {
        this.M_Name = name;
    }

    public void AddAlbum(Album album)
    {
        _albums.Add(album);
    }

    public void AddRating(Rating rating)
    {
        _ratings.Add(rating);
    }

    public void showDiscography()
    {
        string titleMusic = "Music Name";
        string titleArtist = "Artist";
        string titleDuration = "Duration";
        string titleAvailable = "Available";

        Console.WriteLine($"@ Discography: {this.M_Name.ToUpperInvariant()}");
  
        foreach (var album in _albums)
        {
            album.showAlbum();
        }
    }
}
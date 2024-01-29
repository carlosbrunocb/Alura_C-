class Band
{
    public Band(string name) 
    { 
        this.M_Name = name;
    }

    private List<Album> _albums = new List<Album>();
    public string M_Name { get; }

    public void AddAlbum(Album album)
    {
        _albums.Add(album);
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
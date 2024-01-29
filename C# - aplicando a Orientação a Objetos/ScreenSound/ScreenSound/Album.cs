class Album
{
    public Album(string name)
    {
        this.M_Name = name;
    }

    private List<Music> _sounds = new List<Music>();
    public string M_Name { get; set; }
    public int M_Duration => _sounds.Sum(sound => sound.M_Duration);
    //public int Duration { get; set; } = 0;


    public void AddSound(Music sound) 
    {
        _sounds.Add(sound);

        //Duration += sound.M_Duration;
    }

    public void showAlbum()
    {
        string titleMusic = "Music Name";
        string titleArtist = "Artist";
        string titleDuration = "Duration";
        string titleAvailable = "Available";

        Console.WriteLine($"+ Album: {this.M_Name.ToUpperInvariant()}");
        Console.WriteLine($"+ Duration: {this.M_Duration}");
        Console.WriteLine(
            $"# {titleMusic}{string.Empty.PadLeft(25 - titleMusic.Length, ' ')}" +
            $"# {titleArtist}{string.Empty.PadLeft(25 - titleArtist.Length, ' ')}" +
            $"# {titleDuration}{string.Empty.PadLeft(25 - titleDuration.Length, ' ')}" +
            $"# {titleAvailable}");

        foreach (var sound in _sounds)
        {
            
            Console.WriteLine(
                $"# {sound.M_MusicName}{string.Empty.PadLeft(25 - sound.M_MusicName.Length, ' ')}" +
                $"# {sound.M_Artist.M_Name}{string.Empty.PadLeft(25 - sound.M_Artist.M_Name.Length, ' ')}" +
                $"# {sound.M_Duration}{string.Empty.PadLeft(25 - sound.M_Duration.ToString().Length, ' ')}" +
                $"# {(sound.M_Available ? "Available on plan" : "Purchase the Plus+ plan")}");
        }
    }
}
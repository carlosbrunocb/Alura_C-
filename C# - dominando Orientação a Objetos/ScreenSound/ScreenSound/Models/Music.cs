namespace ScreenSound.Models;

internal class Music
{
    public Music(Band artist, string musicName)
    {
        M_Artist = artist;
        M_MusicName = musicName;
    }

    // Method with properties
    // {get; set; } is used to indicate that attribute
    // must follow some condition for your attribution.
    // We can inform the trading rule.
    public string M_MusicName { get;}
    public Band M_Artist { get;}
    public int M_Duration { get; set; } = 0;
    public bool M_Available { get; set;} = false;

    // Arrow Function: To execute GET Function
    public string M_Description => $"The {M_MusicName} sound belongs to the band {M_Artist}"; 
    //public string M_Description {
    //    get 
    //    { 
    //        return $"The {M_MusicName} sound belongs to the band {M_Artist}"; 
    //    }
    //}

    //Music(string musicName, string artist, int m_duration, bool available = false) { }
    public void informDatasheet()
    {
        string titleMusic = "Music Name";
        string titleArtist = "Artist";
        string titleDuration = "Duration";
        string titleAvailable = "Available";

        Console.WriteLine($"# {titleMusic}{string.Empty.PadLeft(25 - titleMusic.Length, ' ')}" +
            $"# {titleArtist}{string.Empty.PadLeft(25 - titleArtist.Length, ' ')}" +
            $"# {titleDuration}{string.Empty.PadLeft(25 - titleDuration.Length, ' ')}" +
            $"# {titleAvailable}");
        Console.Write($"# {this.M_MusicName}{string.Empty.PadLeft(25 - this.M_MusicName.Length, ' ')}" +
            $"# {this.M_Artist.M_Name}{string.Empty.PadLeft(25 - this.M_Artist.M_Name.Length, ' ')}" +
            $"# {this.M_Duration}{string.Empty.PadLeft(25 - this.M_Duration.ToString().Length, ' ')}" +
            $"# {(M_Available ? "Available on plan" : "Purchase the Plus+ plan")}");
        
    }
}


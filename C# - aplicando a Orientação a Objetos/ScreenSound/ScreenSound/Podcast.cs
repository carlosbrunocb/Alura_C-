class Podcast
{
    public Podcast(string host, string name)
    {
        M_Host = host;
        M_Name = name;
    }

    private List<Episode> m_EpisodeList = new List<Episode>();

    public string M_Host { get; }
    public string M_Name { get; }
    public int M_EpisodesNumber => m_EpisodeList.Count();

    public void addEpisode(Episode episode) 
    {
        m_EpisodeList.Add(episode);
    }

    public void showAbout() 
    {
        string titleEpisode = "Episode";
        //string titleTrack = "Track";
        string titleDuration = "Duration";
        string titleSummary = "Summary";

        Console.WriteLine($"+ Podcast: {this.M_Name.ToUpperInvariant()}");
        Console.WriteLine($"+ Host: {this.M_Host}");
        Console.WriteLine($"+ Number of Episodes: {this.M_EpisodesNumber}");

        Console.WriteLine(
                //$"# {titleTrack}{string.Empty.PadLeft(10 - titleTrack.Length, ' ')}" +
                $"# {titleEpisode}{string.Empty.PadLeft(25 - titleEpisode.Length, ' ')}" +
                $"# {titleDuration}");

        foreach (var episode in m_EpisodeList.OrderBy(e => e.M_Track))
        {
            Console.WriteLine(
                $"# {episode.M_Track}. " +
                $"{episode.M_Title}{string.Empty.PadLeft(23 - (episode.M_Title.Length + episode.M_Track.ToString().Length), ' ')}" +
                $"# {episode.M_Duration} min");
            Console.WriteLine($"# {titleSummary}: {episode.M_SubjectBrief}");
        }
    }

    public void showTrack()
    {
        Console.WriteLine($"+ Podcast: {this.M_Name.ToUpperInvariant()}");
        foreach (var episode in m_EpisodeList.OrderBy(e => e.M_Track))
        {
            Console.WriteLine(episode.M_Summary);
        }

    }
}
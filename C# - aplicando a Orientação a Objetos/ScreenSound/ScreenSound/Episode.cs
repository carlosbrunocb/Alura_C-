class Episode
{
    public Episode(int track, string title, int duration)
    {
        M_Track = track;
        M_Title = title;
        M_Duration = duration;
    }

    private List<string> m_GuestList = new List<string>();

    public int M_Duration { get; }
    public int M_Track { get; }
    public string M_SubjectBrief { get; set; }
    public string M_Summary => $"{M_Track}. {M_Title} ({M_Duration} min)\n" +
        $"{string.Empty.PadLeft(M_Track.ToString().Length, ' ')}  Guests: {string.Join(", ", m_GuestList)}";
    public string M_Title { get; }

    public void AddGuest (string name)
    {
        m_GuestList.Add(name);
    }
}
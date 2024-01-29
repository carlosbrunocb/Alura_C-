//Music obj_music = new Music();

//obj_music.M_MusicName = "Imagine";
//obj_music.M_Artist = "The Beatles";
//obj_music.M_Duration = 180;
//obj_music.M_Available = false;
////obj_music.m_available;

////Console.WriteLine($"{obj_music.m_musicName} | {obj_music.m_artist} | " +
////    $"{obj_music.m_duration} | {obj_music.m_available}");

//Console.WriteLine(obj_music.M_Description);
//obj_music.informDatasheet();

Band queen = new Band("Queen");
//queen.M_Name = "Queen";

Album queenAlbum = new Album("A night at he opera");
//queenAlbum.M_Name = "A night at he opera";

Music sound1 = new Music(queen, "Love my life")
{
    M_Duration = 213,
    M_Available = true,
};
//sound1.M_MusicName = "Love my life";
//sound1.M_Artist = "Queen";
//sound1.M_Duration = 213;

Music sound2 = new Music(queen, "Bohemian Rhapsody")
{
    M_Duration = 354,
    M_Available = false,
};
//sound2.M_MusicName = "Bohemian Rhapsody";
//sound2.M_Artist = "Queen";
//sound2.M_Duration = 354;

queenAlbum.AddSound(sound1);
queenAlbum.AddSound(sound2);

//queenAlbum.showAlbum();


queen.AddAlbum(queenAlbum);
queen.showDiscography();

Console.WriteLine("\n--------");
Console.WriteLine("Podcast");



//Episode episode01 = new (1, "Welcome to C++", 10)
Episode episode01 = new(2, "Welcome to C++", 10)
{
    M_SubjectBrief = "A brief origin of C++ and its popularization."
};

episode01.AddGuest("Diogo Rafael Lima");
episode01.AddGuest("Fernando Garcia");

//Episode episode02 = new Episode(2, "Introdution of C++", 15)
Episode episode02 = new Episode(1, "Introdution of C++", 15)
                    {
                        M_SubjectBrief = "Overview of C++."
                    };
episode02.AddGuest("João Roberto");
episode02.AddGuest("Thiago Leite");
episode02.AddGuest("Brian Smith");

Podcast podcast01 = new Podcast("Brazilian Host", "C++ Today");

podcast01.addEpisode(episode01);
podcast01.addEpisode(episode02);
podcast01.showAbout();

Console.WriteLine("\n\n--------");
podcast01.showTrack();

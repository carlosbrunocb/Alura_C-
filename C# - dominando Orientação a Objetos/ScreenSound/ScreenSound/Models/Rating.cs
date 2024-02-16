using static System.Formats.Asn1.AsnWriter;

namespace ScreenSound.Models;

internal class Rating
{
    public Rating(int score)
    {
        if (score < 0) score = 0;
        if (score > 10) score = 10;

        M_Score = score;
    }

    public int M_Score { get; }

    public static Rating Parse(string text) 
    {
        int score = int.Parse(text);

        return new Rating(score);
    }
}

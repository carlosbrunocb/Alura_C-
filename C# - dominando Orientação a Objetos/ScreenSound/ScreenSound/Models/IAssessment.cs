namespace ScreenSound.Models;

internal interface IAssessment
{
    void AddRating(Rating rating);
    double M_AverageRating { get; }
}

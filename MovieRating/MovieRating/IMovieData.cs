using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating
{
    public interface IMovieData
    {
        int Reviews(int Reviewer);
        double AverageGrade(double Reviewer);
        double ReviewerAmount(int Movie, int Reviewer);
        int MovieReviewsAmount(int Movie);
        double AverageReviewerGrade(int Movie);
        int GradeAmount(int Movie, int Grade);
        int[] MovieTopGrade();
        int[] CountReviews();
        int[] GetTopGradeMovies(int MovieAmount);
        int[] GetMovieReviewed(int ReviewedMovie);
        int[] GetReviewersMovie(int MovieReviewed);
    }
}

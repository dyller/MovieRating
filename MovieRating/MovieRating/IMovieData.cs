using System;
using System.Collections.Generic;
using System.Text;

namespace MovieRating
{
    public interface IMovieData
    {
        //1. On input N, what are the number of reviews from reviewer N?
        int Reviews(int Reviewer);
        //2. On input N, what is the average rate that reviewer N had given?
        double AverageGrade(double Reviewer);
        //3. On input N and G, how many times has reviewer N given a movie grade G?
        double ReviewerAmount(int Movie, int Reviewer);
        //4. On input N, how many have reviewed movie N?
        int MovieReviewsAmount(int Movie);
        //5. On input N, what is the average rate the movie N had received?
        double AverageReviewerGrade(int Movie);
        //6. On input N and G, how many times had movie N received grade G?
        int GradeAmount(int Movie, int Grade);
        //7. What is the id(s) of the movie(s) with the highest number of top rates (5)?
        int MovieTopGrade();
        //8. What reviewer(s) had done most reviews?
        int[] CountReviews();
        //9. On input N, what is top N of movies? The score of a movie is its average rate.
        int[] GetTopGradeMovies(int MovieAmount);
        /**
         *10. On input N, what are the movies that reviewer N has reviewed? The list should
            be sorted decreasing by rate first, and date secondly.
         * */
        int[] GetMovieReviewed(int ReviewedMovie);
        /**
         * 11. On input N, what are the reviewers that have reviewed movie N? The list
            should be sorted decreasing by rate first, and date secondly.
         * */
        int[] GetReviewersMovie(int MovieReviewed);
    }
}

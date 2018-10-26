using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MovieRating
{
    class MovieData : IMovieData
    {
        
        public double AverageGrade(double Reviewer)
        {
            throw new NotImplementedException();
        }

        public double AverageReviewerGrade(int Movie)
        {
            throw new NotImplementedException();
        }

        public int[] CountReviews()
        {
            throw new NotImplementedException();
        }

        public int[] GetMovieReviewed(int ReviewedMovie)
        {
            throw new NotImplementedException();
        }

        public int[] GetReviewersMovie(int MovieReviewed)
        {
            throw new NotImplementedException();
        }

        public int[] GetTopGradeMovies(int MovieAmount)
        {
            throw new NotImplementedException();
        }

        public int GradeAmount(int Movie, int Grade)
        {
            throw new NotImplementedException();
        }

        public int MovieReviewsAmount(int Movie)
        {
            throw new NotImplementedException();
        }

        public int[] MovieTopGrade()
        {
            throw new NotImplementedException();
        }

        public double ReviewerAmount(int Movie, int Reviewer)
        {
            throw new NotImplementedException();
        }

        public int Reviews(int Reviewer)
        {
            throw new NotImplementedException();
        }
    }
}

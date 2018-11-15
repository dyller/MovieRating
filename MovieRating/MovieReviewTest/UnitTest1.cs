using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;

namespace MovieReviewTest
{
    [TestClass]
    public class UnitTest1
    {
       MovieData movie = new MovieData();
        
        //1
        [TestMethod]
        public void Reviews()
        {
            int amountOffReviews=  movie.Reviews(1);
            Assert.AreEqual(547, amountOffReviews);


        }
        //2
        [TestMethod]
        public void AverageGrade()
        {
            double avergeGrade = movie.AverageGrade(1000);
            Assert.AreEqual(2.5, avergeGrade);
        }
        //3
        [TestMethod]
        public void ReviewerAmount()
        {
            double amountOfReviewsOfThisMovie = movie.ReviewerAmount(1000, 1000);
            Assert.AreEqual(4, amountOfReviewsOfThisMovie);
        }
        //4
        [TestMethod]
        public void MovieReviewsAmount()
        {
            double AmountOfReviews = movie.MovieReviewsAmount(1000);
            Assert.AreEqual(5, AmountOfReviews);
        }
        //5
        [TestMethod]
        public void AverageReviewerGrade()
        {
            double avergeGrade = movie.AverageReviewerGrade(1000);
            Assert.AreEqual(2.5, avergeGrade);
        }
        //6
        [TestMethod]
        public void GradeAmount()
        {
            double MovieAmountOfThisGrade = movie.GradeAmount(1000,4);
            Assert.AreEqual(1, MovieAmountOfThisGrade);
        }
        //7
        [TestMethod]
        public void MovieTopGrade()
        {
            double topGradeMovie = movie.MovieTopGrade();
            Assert.AreEqual(1664010, topGradeMovie);
        }
        //8. What reviewer(s) had done most reviews?
       
        [TestMethod]
        public void CountReviews()
        {
            int[] movieCount = movie.CountReviews();
            Assert.AreEqual(1, movieCount.Length);
            Assert.AreEqual(571, movieCount.GetValue(0));
        }

        //9
        [TestMethod]
        public void GetTopGradeMovies()
        {
            var topGradeMovie = movie.GetTopGradeMovies(5);
            Assert.AreEqual(topGradeMovie.Count, 5);
        }

        //10
        [TestMethod]
        public void GetMovieReviewed()
        {
            var topGradeMovie = movie.GetMovieReviewed(1000);
            Assert.AreEqual(4, topGradeMovie.Length);
            Assert.IsTrue(topGradeMovie[0] >= topGradeMovie[1]);
        }

        //11
        [TestMethod]
        public void GetReviewersMovie()
        {
            var topGradeMovie = movie.GetReviewersMovie(1000);
            Assert.AreEqual(4, topGradeMovie.Length);
            Assert.IsTrue(topGradeMovie[0] >= topGradeMovie[1]);
        }

    }
}

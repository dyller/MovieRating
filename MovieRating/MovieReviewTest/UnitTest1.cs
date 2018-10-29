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

        //2
        }
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
            Assert.AreEqual(4, AmountOfReviews);

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

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRating
{
    public class MovieData : IMovieData
    {
        public void JustBasic()
        {
            using (StreamReader r = new StreamReader("C:/Users/Samuel/Downloads/ratings.json"))
            {
                Console.WriteLine("Reading File...");
                var json = r.ReadToEnd();
                List<Reviews> list = JsonConvert.DeserializeObject<List<Reviews>>(json);
                Console.WriteLine("Deserialization finished.");

                Console.WriteLine("Do you want start taking shits?");
                string val = Console.ReadLine();
                if (val == "Yes")
                {
                    Console.WriteLine("Write");
                    int number = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in list.Where(w => w.Reviewer == number))
                    {
                        Console.WriteLine("Reviewer " + item.Reviewer + "Movie " + item.Movie);
                    }
                }
                else
                {
                    Console.WriteLine("You decided to dont");
                }

            }
            Console.ReadLine();
        }
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

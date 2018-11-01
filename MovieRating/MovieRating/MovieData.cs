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
       
       // public List<Tuple<double, double>> movieNGrade= new List<Tuple<double, double>>();
      static  string path = @"C:\Users\jacob\Downloads\ratings.json";

      static  IEnumerable<Reviews> list = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));


        //1. On input N, what are the number of reviews from reviewer N?
        public int Reviews(int Reviewer)
        {

            return list.Where(info => info.Reviewer == Reviewer).Count();
        }

        //2
        public double AverageGrade(double Reviewer)
        {

            return list.Where(info => info.Reviewer == Reviewer).Average(r=> r.Grade);
        }

        //3
        public double ReviewerAmount(int Movie, int Reviewer)
        {
            
            return list.Where(r => r.Movie == Movie).Where(info => info.Reviewer == Reviewer).Count();
        }

        //4
        public int MovieReviewsAmount(int Movie)
        {


            return list.Where(info => info.Movie == Movie).Count();
        }

        //5
        public double AverageReviewerGrade(int Movie)
        {

            return list.Where(info => info.Movie == Movie).Average(r => r.Grade);
        }

        //6
        public int GradeAmount(int Movie, int Grade)
        {


            return list.Where(info => info.Movie == Movie).Where(k => k.Grade == Grade).Count();
        }

        //7. What is the id(s) of the movie(s) with the highest number of top rates (5)?
        public int MovieTopGrade()
        {
           

            return 
                list.Where(g => g.Grade == 5).GroupBy(info => info.Movie)
                           .Select(group => new
                           {
                               Metric = group.Key,
                               Count = group.Count()
                           })
                           .OrderByDescending(x => x.Count).FirstOrDefault().Metric;
        }
        //8
        public int[] CountReviews()
        {
            int countp = 0;
            int[] res= null;
            List<int> tres = new List<int>();
            foreach (var item in list.GroupBy(info => info.Reviewer)
                           .Select(group => new
                           {
                               Metric = group.Key,
                               Count = group.Count()
                           })
                           .OrderByDescending(x => x.Count))
            {
                if (item.Count == countp || countp == 0)
                {
                    countp = item.Count;
                    tres.Add(item.Metric);
                }
                else
                {
                    res = new int[tres.Count];
                    int count = 0;
                    foreach (var reviewer in tres)
                    {
                        res[count] = reviewer;
                        count++;
                    }
                    break;
                }
            }
            return res;
        }

        //9 On input N, what is top N of movies? The score of a movie is its average rate.
        public List<double> GetTopGradeMovies(int MovieAmount)
        {
            List<double>  tres= new List<double>();
            foreach (var item in list.GroupBy(info => info.Movie)
                          .Select(group => new
                          {
                              Metric = group.Key,
                              avg = group.Average(r => r.Grade)
                          })
                          .OrderByDescending(x => x.avg).Take(MovieAmount).ToList())
            {
                tres.Add(item.Metric);
            }
            return tres;
        }

        //10
        public int[] GetMovieReviewed(int ReviewedMovie)
        {
            int[] MovieArray = new int[Reviews(ReviewedMovie)];
            int count = 0;
            foreach (var item in list.Where(w => w.Reviewer == ReviewedMovie).OrderByDescending(d => d.Grade).ThenByDescending(r => r.Date))
            {
                MovieArray[count] = item.Movie;
                count++;
            }
            return MovieArray;
        }

        //11
        public int[] GetReviewersMovie(int MovieReviewed)
        {
            int[] MovieArray = new int[Reviews(MovieReviewed)];
            int count = 0;

            foreach (var item in list.Where(w => w.Movie == MovieReviewed).OrderByDescending(d => d.Grade).ThenByDescending(r => r.Date))
            {
                MovieArray[count] = item.Reviewer;
                count++;
            }
            return MovieArray;
        }
    }
}

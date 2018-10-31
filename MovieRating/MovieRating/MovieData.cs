﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRating
{
    public class MovieData : IMovieData
    {
        public List<Tuple<double, double>> movieNGrade= new List<Tuple<double, double>>();
      static  string path = @"C:\Users\jacob\Downloads\ratings.json";

      static  IEnumerable<Reviews> list = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));
        

        //1
        public int Reviews(int Reviewer)
        {

            return list.GroupBy(info => info.Reviewer == Reviewer)
                           .Select(group => new
                           {
                               Metric = group.Key,
                               Count = group.Count()
                           }).FirstOrDefault().Count;
        }

        //2
        public double AverageGrade(double Reviewer)
        {
            
            return list.GroupBy(info => info.Reviewer == Reviewer)
                           .Select(group => new
                           {
                               Metric = group.Key,
                               avg = group.Average(r => r.Grade)
                           }).FirstOrDefault().avg;
        }

        //3
        public double ReviewerAmount(int Movie, int Reviewer)
        {
            
            return list.Where(r => r.Movie == 1000).GroupBy(info => info.Reviewer == 1000)
                         .Select(group => new
                         {
                             Metric = group.Key,
                             count = group.Count()
                         }).FirstOrDefault().count;
        }

        //4
        public int MovieReviewsAmount(int Movie)
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));

            Console.Write("Insert Movie ID: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            /*Console.Write("Grade: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());*/
            int count = 0;

            foreach (var item in hash.Where(w => w.Movie == userInput1))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
            }
            Console.WriteLine("Number of reviewers that have reviewed this movie: " + count);
            Console.WriteLine("waa");
            Console.ReadLine();

            return count;
        }

        //5
        public double AverageReviewerGrade(int Movie)
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));

            Console.Write("Insert Movie ID: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            /*Console.Write("Grade: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());*/
            int count = 0;
            double avg = 0;
            foreach (var item in hash.Where(w => w.Movie == userInput1))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
            }
            //decimal avg = hash.Average(r => r.Grade);

            avg = hash.Where(i => i.Movie == userInput1).Average(r => r.Grade);

            Console.WriteLine("Number of reviewers that have reviewed this movie: " + count);
            Console.WriteLine("Avg: " + avg.ToString("#.##"));
            Console.ReadLine();

            return count;
        }

        //6
        public int GradeAmount(int Movie, int Grade)
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));

            Console.Write("Reviewer ID: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in hash.Where(w => w.Movie == userInput1).Where(o => o.Grade == userInput2))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine("waa");
            Console.ReadLine();

            return count;
        }

        //7
        public int MovieTopGrade()
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));
            int count = 0;
            int top = 5;
            int revs = 0;
            foreach (var item in hash.Where(g => g.Grade == top).Take(5))
            {
                //Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
                Console.WriteLine("Movie ID: " + item.Movie + " Top Grade " + top);
                revs = Convert.ToInt32(item.Movie);
            }
            Console.WriteLine("Top Grade " + top + " " + revs);
            Console.ReadLine();

            return revs;
        }
        //8
        public int[] CountReviews()
        {
            int[] res = new int[1];
            res[0]=list.GroupBy(info => info.Reviewer)
                           .Select(group => new
                           {
                               Metric = group.Key,
                               Count = group.Count()
                           })
                           .OrderByDescending(x => x.Count).FirstOrDefault().Metric;
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
                          .OrderByDescending(x => x.avg).Take(5).ToList())
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
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            foreach (var item in list.Where(w => w.Movie == userInput1).OrderBy(o => o.Reviewer).OrderByDescending(d => d.Grade).ThenByDescending(r => r.Date))
            {
                MovieArray[count] = item.Reviewer;
                count++;
            }
            return MovieArray;
        }
    }
}

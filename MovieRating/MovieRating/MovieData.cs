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
       static string path = @"C:\Users\jacob\Downloads\ratings.json";

      static IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));
       public List<Reviews> list;
         
        //This method is someway a layout.
        //public void JustBasic()
        //{
        //    using (StreamReader r = new StreamReader("C:/Users/Samuel/Downloads/ratings.json"))
        //    {
        //        Console.WriteLine("Reading File...");
        //        var json = r.ReadToEnd();
        //        List<Reviews> list = JsonConvert.DeserializeObject<List<Reviews>>(json);
        //        Console.WriteLine("Deserialization finished.");

        //        Console.WriteLine("Do you want start taking shits?");
        //        string val = Console.ReadLine();
        //        if (val == "Yes")
        //        {
        //            Console.WriteLine("Write");
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            foreach (var item in list.Where(w => w.Reviewer == number))
        //            {
        //                Console.WriteLine("Reviewer " + item.Reviewer + "Movie " + item.Movie);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("You decided to dont");
        //        }

        //    }
        //    Console.ReadLine();
        //}


        //1
        public int Reviews(int Reviewer)
        {
            int amountOfReviewer = 0;
            //int count = 0;
            foreach (var item in hash.Where(w => w.Reviewer == Reviewer))
            {

                amountOfReviewer++;
            }
            return amountOfReviewer;
        }

        //2
        public decimal AverageGrade(double Reviewer)
        {
            List<double> gradeList = new List<double>();
            double total = 0;
            double amount = 0;
            foreach (var grade in list.Where(g => g.Reviewer == Reviewer))
            {
                gradeList.Add(grade.Grade);
                total = total + 1;
            }
            foreach (var number in gradeList)
            {
                amount = amount + number;
            }
            double average = amount / total;
            Console.WriteLine("The average of this reviewer is....:" + Math.Round(average, 2));

            return average;
        }

        //3
        public double ReviewerAmount(int Movie, int Reviewer)
        {
            string path = @"W:/Skóli/CompulsoryTDDJSON/ratings.json";
            Console.WriteLine("Works");

            IEnumerable<Reviews> hash = JsonConvert.DeserializeObject<IEnumerable<Reviews>>(File.ReadAllText(path));

            Console.Write("Reviewer ID: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade: ");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            foreach (var item in hash.Where(w => w.Reviewer == userInput1).Where(o => o.Grade == userInput2))
            {
                Console.WriteLine("Reviewer: " + item.Reviewer + " Movie: " + item.Movie + " Grade: " + item.Grade);
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine("waa");
            Console.ReadLine();
            return count;
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
            throw new NotImplementedException();
        }

        //9
        public int[] GetTopGradeMovies(int MovieAmount)
        {
            throw new NotImplementedException();
        }
      
        //10
        public int[] GetMovieReviewed(int ReviewedMovie)
        {
            int[][] MovieList = new int[Reviews(ReviewedMovie)][];
           

            foreach (var item in hash.Where(w => w.Movie == ReviewedMovie))
            {
                int count = 0;
                foreach (int[] row in MovieList)
                {
                    count++;
                    if (row[0] == item.Movie)
                    {

                    }
                }
            }
            return null;
        }

        //11
        public int[] GetReviewersMovie(int MovieReviewed)
        {
            throw new NotImplementedException();
        }
    }
}

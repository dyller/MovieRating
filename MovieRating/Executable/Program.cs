using MovieRating;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            var mD = new MovieData();

            using (StreamReader r = new StreamReader("C:/Users/Samuel/Downloads/ratings.json"))
            {
                Console.WriteLine("Reading File...");
                var json = r.ReadToEnd();
                 mD.list = JsonConvert.DeserializeObject<List<Reviews>>(json);
                Console.WriteLine("Deserialization finished.");
            }
                Console.WriteLine("In order to execute the method, you need to type a number");
            int number = Convert.ToInt32(Console.ReadLine());
           
            mD.AverageReviewerGrade(number);
            Console.ReadLine();
        }

    }
}

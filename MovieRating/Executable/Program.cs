using MovieRating;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            //Important stuffs
            var mD = new MovieData();
            // Just something pleasant :)
            Console.WriteLine("This can take at least 30m. Are you sure?(y/n)");
            if (Console.ReadLine().Equals("y"))
            {

                Console.WriteLine("This is gonna compute for a very long time, you should go and do another task.");
                //This part is for method #9
            }
            else
            {
                Console.WriteLine("Have a nice day :)");
            }

            Console.WriteLine("In order to execute the method, you need to type a number");
            int number = Convert.ToInt32(Console.ReadLine());

            
            foreach (var item in mD.GetTopGradeMovies(number))
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}


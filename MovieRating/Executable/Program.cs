using MovieRating;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader("C:/Users/Samuel/Downloads/ratings.json"))
            {
                var json = r.ReadToEnd();
                List<Reviews> list = JsonConvert.DeserializeObject<List<Reviews>>(json);
                Console.WriteLine("Deserialization finished.");

                Console.WriteLine("Do you want start taking shits?");
                string val = Console.ReadLine();
                if (val == "Yes")
                {
                    foreach (var item in list.Where(w => w.Reviewer == 1))
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
    }
}

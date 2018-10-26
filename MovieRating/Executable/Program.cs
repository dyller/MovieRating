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
            mD.JustBasic();
        }

    }
}

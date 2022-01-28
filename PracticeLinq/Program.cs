using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>()
            {
                "Mass Effect",
                "KOTOR",
                "Assasin's Creed",
                "Halo",
                "Doom2"
            };

            //strings are Arrays of characters (char)

            //var orderedGameList = gameList.OrderBy(name => name.Length).ToList();

            //foreach(var gameName in orderedGameList)
            //{
            //    Console.WriteLine(gameName);
            //}

            gameList.OrderBy(name => name.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}

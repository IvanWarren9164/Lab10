using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Jaws", "Horror"));
            movies.Add(new Movie("Saw", "Horror"));
            movies.Add(new Movie("Friday The 13th", "Horror"));
            movies.Add(new Movie("Inside Out", "Animated"));
            movies.Add(new Movie("Lion King", "Animated"));
            movies.Add(new Movie("Finding Nemo", "Animated"));
            movies.Add(new Movie("The Incredibles", "Animated"));
            movies.Add(new Movie("Star Wars", "SciFi"));
            movies.Add(new Movie("Battlestar Galactica", "SciFi"));
            movies.Add(new Movie("Bladerunner", "SciFi"));

            bool isRunning = true;
            bool switchRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nSelect a category from the numbered list: \n" +
                    "1: Horror \n" +
                    "2: Animated \n" +
                    "3: SciFi \n");
                bool isInt = int.TryParse(Console.ReadLine(), out int userinput);
                Console.WriteLine("\n");

                while (switchRunning)
                {
                    switch (userinput)
                    {
                        case 1:
                            accessPrintMovie("Horror", movies);
                            break;

                        case 2:
                            accessPrintMovie("Animated", movies);
                            break;
                        case 3:
                            accessPrintMovie("SciFi", movies);
                            break;
                        default:
                            Console.WriteLine("Error, please enter a correct selection from the list \n");
                            isInt = int.TryParse(Console.ReadLine(), out userinput);
                            Console.WriteLine("\n");
                            continue;
                    } 
                        
                    break;
                }

                
                Console.WriteLine("\nWould you like to run the program again? Enter 'yes' or 'Yes' to run again. Enter anything else to close program. \n");
                string breakloop = Console.ReadLine();

                if(breakloop == "yes" || breakloop == "Yes")
                {
                    continue;
                }
                else 
                {
                    break;
                }
                
            }

        }

        public static void accessPrintMovie(string userinput, List<Movie> movies)
        {
            foreach (var movie in movies)
            {
                movie.PrintMovie(userinput);
            }
            
        }

        public class Movie
        {

            public Movie(string title, string category)
            {
                Title = title;
                Category = category;
            }
            private string Title { get; set; }
            private string Category { get; set; }


            public void PrintMovie(string userinput)
            {
               if(userinput == "Horror" && Category == userinput)
                {
                    Console.WriteLine(Title);
                }
                else if(userinput == "Animated" && Category == userinput)
                {
                    Console.WriteLine(Title);
                }
                else if (userinput == "SciFi" && Category == userinput)
                {
                    Console.WriteLine(Title);
                }
            }

        }
    }
}

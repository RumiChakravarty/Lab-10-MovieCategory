using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_10_MovieCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieIO listOfAllTheMovie = new MovieIO();
            Console.WriteLine("Welcome to the Movie List Application!\n");
            MovieIO.default_MovieCatalog.Add(new Movie("ABC", "animated"));
            Console.WriteLine($"There are {MovieIO.default_MovieCatalog.Count} movies in this list.");
            // Console.WriteLine(MovieIO.default_MovieCatalog.Count);
            string numberAgainstMovieCategory = "";

            string movieCategoryYouSelected = "";
            string doYouWantToContinue = "";
            bool isValidCategory = true;
            do
            {
                Console.WriteLine(" 1 - Animated , 2 - Drama , 3 - Horror , 4 - Scifi");
                Console.Write("\nWhat Category are you interested in?(Please select the number) :");
                numberAgainstMovieCategory = Console.ReadLine();
                isValidCategory = true;
                switch (numberAgainstMovieCategory)
                {
                    case "1":
                        movieCategoryYouSelected = "animated";
                        break;
                    case "2":
                        movieCategoryYouSelected = "drama";
                        break;
                    case "3":
                        movieCategoryYouSelected = "horror";
                        break;
                    case "4":
                        movieCategoryYouSelected = "scifi";
                        break;
                    default:
                        Console.WriteLine("Undefined Category");
                        isValidCategory = false;
                        Console.WriteLine(" 1 - Animated , 2 - Drama , 3 - Horror , 4 - Scifi");
                        break;
                }
                if (isValidCategory)
                {
                    Console.WriteLine("Here is the list of " + movieCategoryYouSelected + " movie");

                    int countMovieMatch = 0;
                   foreach (Movie listOfMovie in MovieIO.default_MovieCatalog.OrderBy(m => m.Title))
                    {
                       if (movieCategoryYouSelected == listOfMovie.Category)
                        {
                            //try {
                               // listOfMovie.Oops();

                                Console.WriteLine("Title : " + listOfMovie.Title);
                                countMovieMatch++;
                            //}
                            //catch
                            //{
                            //    Console.WriteLine("An exceptopjn is handled");
                            //}
                        }
                        if (countMovieMatch == 10)
                                break;
                        
                    }

                }
                
                Console.WriteLine("\nDo you want to continue?(yes/no) ");
                doYouWantToContinue = Console.ReadLine().ToLower().Trim();
                if (MovieIO.default_MovieCatalog.Count > 100) {
                    MovieIO.default_MovieCatalog.RemoveAt(100);
                }
                
                Console.WriteLine($"There are {MovieIO.default_MovieCatalog.Count} movies in this list.");

            } while (doYouWantToContinue == "yes");

            

        }
    }
}

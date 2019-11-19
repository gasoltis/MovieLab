using System;
using System.Collections.Generic;


namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<Movie> movieList = new List<Movie>();
                {
                    Movie mov1 = new Movie("Toy Story", "Animation");
                    Movie mov2 = new Movie("Shawshank Redemption", "Drama");
                    Movie mov3 = new Movie("Screem", "Horror");
                    Movie mov4 = new Movie("Forest Gump", "Drama");
                    Movie mov5 = new Movie("Little Mermaid", "Animation");
                    Movie mov6 = new Movie("Pretty Women", "Drama");
                    Movie mov7 = new Movie("CandyMan", "Horror");
                    Movie mov8 = new Movie("Star Wars", "Sci-Fi");
                    Movie mov9 = new Movie("Harry Potter and the Sorcerer's Stone", "Sci-Fi");
                    Movie mov10 = new Movie("Texas Chainsaw", "Horror");

                    movieList.Add(mov1);
                    movieList.Add(mov2);
                    movieList.Add(mov3);
                    movieList.Add(mov4);
                    movieList.Add(mov5);
                    movieList.Add(mov6);
                    movieList.Add(mov7);
                    movieList.Add(mov8);
                    movieList.Add(mov9);
                    movieList.Add(mov10);

                }
                string response = "yes";
                while (response == "yes")
                {

                    try
                    {
                        Console.WriteLine("Animation");
                        Console.WriteLine("Drama");
                        Console.WriteLine("Horror");
                        Console.WriteLine("Sci-Fi");

                        Console.WriteLine("Welcome to the Movie List Application! There are 10 movies in this list." +
                            "What category are you interested in from the list above?");
                        string userInput = Console.ReadLine();

                        foreach (Movie m in movieList)  // m can be any variable name  I.E. now it's this movie, now it's this movie...
                        {
                            if (m.Category == userInput)
                            {
                                Console.WriteLine(m.Title);
                            }

                        }
                            

                        Console.WriteLine($"Would you like to select another Category?" +
                            $"(Enter 'yes' or 'no') ");
                        response = Console.ReadLine();

                        if (response == "yes")
                        {
                            Console.WriteLine("Ok.");
                        }

                        else if (response == "no")
                        {
                            Console.WriteLine("Thank you. Goodbye.");
                        }

                        else
                        {
                            throw new Exception(); // USE AS A "CATCH-ALL" FOR ANYTHING OTHER THAN YES OR NO HERE (catch (Exception))
                        }

                    }  // END OF TRY

                    catch (FormatException) // IF ANYTHING OTHER THAN AN INT
                    {
                        Console.WriteLine("That is not a movie. Please try again.");
                    }
                    catch (Exception )  // FROM 'THROW NEW EXCEPTION' ABOVE AS A KIND OF CATCH ALL
                    {
                        Console.WriteLine("That input is not recognized. Please answer exactly as specified. Please try over.");
                        response = "yes";  // THE 'YES' FORCES THE EXCEPTION TO LOOP BACK TO THE BEGINNING
                    }

                    // Check for null
                    //if (movieList != null)
                    //{
                    //    movieList.Close();
                    //}


                }  // END OF WHILE
            }
        }
    }
}
    


   


        
    






// HARD CODED LIST OF CATEGORY
// IF NOT IN A VALID CATEGORY - PRINT OUT A MESSAGE 
// create boolian before foreach: bool has found match = false -- if (set has found match to true) after foreach block 
//checked the state of havefound match = false; print message "there were no movies of that category"
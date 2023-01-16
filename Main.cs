// Program for Movie List as a library 

using ConsoleApp1;


namespace Program
{
    class Program
    {   
        static void Main(string[] args)
        {
            {
                Console.Title = "MOVIE LIST";
                MovieFunctions movie = new MovieFunctions();
                while (true)
                {
                    Console.WriteLine("1. Add A nwe movie\n2. Find your movie");
                    Console.WriteLine("3. Remove movie\n4. Show movie list ");
                    Console.WriteLine("0. Exit\n");

                    Console.WriteLine("Enter Your Choice ... ");
                    String Cho = Console.ReadLine();
                    try
                    {
                        int Ch = Convert.ToInt32(Cho);
                        if (Ch == 0) break;
                        if (Ch == 1)
                        {
                            Console.WriteLine("Enter movie Name .... ");
                            String Name = Console.ReadLine();
                            movie.addMovie(Name);
                            Console.WriteLine("Movie is added ");
                        }
                        if (Ch == 2)
                        {
                            movie.showMovie();
                        }
                        if (Ch == 3)
                        {
                            Console.WriteLine("Enter move name .... ");
                            string name = Console.ReadLine();
                            movie.removeMovie(name);
                        }
                        if (Ch == 4)
                        {
                            movie.showMovieList();
                        }
                    }

                    catch
                    {
                        if (Cho.ToLower() == "Clear".ToLower()) Console.Clear();
                        else if (Cho.ToLower() == "Exit".ToLower()) break;
                    }
                }
            }
        }
    }
}

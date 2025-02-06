using System;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();

        p1.SetName("Jerry");
        
        p1.SetAge(23);


        p1.Display();

       string theName =  p1.GetName();
       Console.WriteLine($"The person's name was: {theName}");

       Person p2 = new Person("Mary", 18);
       p2.Display();
    }







        /*
        static void DisplayMovie(Movie aMovie)
        {
            Console.WriteLine($"{aMovie._title} - {aMovie._year}");
        }
        /
        */
        // Movie favoriteMovie = new Movie();
        // favoriteMovie._title = "Star Wars";
        // favoriteMovie._year = 1977;
        // favoriteMovie._runtime = 150;
        // favoriteMovie._rating = "PG";

        // Movie otherMovie = new Movie();
        // otherMovie._title = "Avatar";
        // otherMovie._year = 2009;
        // otherMovie._rating = "PG-13";
        // otherMovie._runtime = 162;

        // favoriteMovie.Display();

        //DisplayMovie(favoriteMovie);
        //DisplayMovie(otherMovie);
}
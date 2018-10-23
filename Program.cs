using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Think of a number between 1 and 100. Ready? (Press Enter)");
      Console.ReadLine();
      int Max = 100;
      int Min = 1;
      int Count = 1;
      var Loop = true;
      while (Loop == true)
      {
        if (Max < Min)
        {
          Console.WriteLine("Liar");
          Console.ReadLine();
          return;

        }
        Random rdm = new Random();
        int nbr = rdm.Next(Min, Max);
        Console.WriteLine("Is your Number " + nbr + "? (Higher? Lower? Yes!)");
        string Answer = Console.ReadLine();

        if (Answer == "Higher")
        {
          Min = nbr + 1;
          Count = Count + 1;
        }
        else if (Answer == "Lower")
        {
          Max = nbr - 1;
          Count = Count + 1;
        }
        else if (Answer == "Yes")
        {
          if (Count == 1)
          {
            Console.WriteLine("Your Number is " + nbr + "! It Took 1 Guess.");
            Console.WriteLine("Play Again? (Yes or No)");
          }
          if (Count > 1)
          {
            Console.WriteLine("Your Number is " + nbr + "! It Took " + Count + " Guesses.");
            Console.WriteLine("Play Again? (Yes or No)");
          }
          string input2 = Console.ReadLine();
          if (input2 == "Yes")
          {
            Console.Clear();
            Main(args);
          }
          else
          {
            return;
          }
        }
        else
        {
          return;
        }
      }
    }
  }
}

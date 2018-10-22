using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Think of a number between 1 and 100. Ready? (Press Enter)");
      Console.ReadLine();
      int Max = 100;
      int Min = 1;
      int Count = 1;
      var Loop = true;
      while (Loop == true)
      {
        Random rdm = new Random();
        int nbr = rdm.Next(Min, Max);
        Console.WriteLine("Is your Number " + nbr + "? (Higher? Lower? Yes!)");
        string Answer = Console.ReadLine();
        if (Max == Min || Min == Max)
        {
          Console.WriteLine("Liar");
          Console.ReadLine();
          Loop = false;
        }
        if (Answer == "Higher")
        {
          Min = nbr + 1;
          Count = Count + 1;
        }
        if (Answer == "Lower")
        {
          Max = nbr - 1;
          Count = Count + 1;
        }
        if (Answer == "Yes")
        {
          Console.WriteLine("Your Number is " + nbr + "! It Took " + Count + " Guesses.");
          Console.WriteLine("Play Again? (Yes or No)");

          string input2 = Console.ReadLine();
          if (input2 == "Yes")
          {
            Main(args);
          }
          if (input2 == "No")
          {
            Loop = false;
          }
        }
        if (Answer == "")
        {
          return;
        }
      }
    }
  }
}

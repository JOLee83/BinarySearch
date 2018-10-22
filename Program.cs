using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Think of a number between 1 and 100. Ready? (Press Enter)");
      Console.ReadLine();
      Loop();
    }
    public static int Max = 100;
    public static int Min = 1;

    public static int Count = 1;
    private static void Loop()
    {


      Random rdm = new Random();
      int nbr = rdm.Next(Min, Max);


      Console.WriteLine("Is your Number " + nbr + "? Higher? Lower? Yes!");
      string Answer = Console.ReadLine();
      if (Max == Min || Min == Max)
      {
        Console.WriteLine("Liar");
        Console.ReadLine();
        return;

      }
      if (Answer == "Higher")
      {
        Min = nbr + 1;
        Count = Count + 1;


        Loop();
      }

      if (Answer == "Lower")
      {
        Max = nbr - 1;
        Count = Count + 1;

        Loop();

      }
      if (Answer == "Yes")
      {
        Console.WriteLine("Your Number is " + nbr + "! It Took " + Count + " Guesses.");
        Console.ReadLine();
        return;


      }

    }
  }
}

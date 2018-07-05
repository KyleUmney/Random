using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomThing
{
  class Program
  {
    static void Main(string[] args)
    {
      Random rnd = new Random();

      string result = string.Empty;

      string[] abverb = File.ReadAllLines("abverbs.txt");
      string[] verb = File.ReadAllLines("verbs.txt");
      string[] myyour = new string[] { "my", "your" };
      string[] adjective = File.ReadAllLines("adjectives.txt");
      string[] noun = File.ReadAllLines("noun.txt");

      while (Console.ReadKey(true).Key == ConsoleKey.Enter)
      {
        string[] structure = new string[]
       {
        abverb[rnd.Next(0,abverb.Length)],
        verb[rnd.Next(0,verb.Length)],
        myyour[rnd.Next(0,myyour.Length)],
        adjective[rnd.Next(0,adjective.Length)],
        noun[rnd.Next(0,noun.Length)],
       };
        foreach (var struc in structure)
        {
          if (!result.Contains(struc))
            result += $"{struc} ";
        }
        Console.WriteLine($"{result}");
        result = string.Empty;
        Console.ReadKey(false);
      }
      Console.ReadLine();
    }
  }
}

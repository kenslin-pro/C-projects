using System;

class Program
{
  static void Main(string[] args)
  {

    Console.WriteLine("Welcome to Scripture Memorizer Game!!!!!\n");

    Scripture scripture = new Scripture("Psalms 10:10\n", "The helpless are crushed, sink down, and fall by his might. 10 Their helpless victims are crushed; they fall beneath the strength of the wicked.");

    Console.Clear();
    scripture.DisplayScripture();
    while (true)
    {
      Console.WriteLine("\nPress enter to hide a word or type quit to exit:");
      string userInput = Console.ReadLine();
      if (userInput.ToLower() == "quit")
      {
        break;

      }
      else
      {
        Console.Clear();
        scripture.HideWord();
        scripture.DisplayScripture();
        if (scripture.AllWordsHidden())
        {
          Console.WriteLine("Bravo you have done it!!!!");
          break;
        }
      }
    }
  }

}

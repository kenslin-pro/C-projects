class Program
{
  static void Main(string[] args)
  {
    int option = 0;

    while (option != 4)
    {
      Console.Clear();
      Console.WriteLine("WELCOME TO MINDFULNES ACTIVITY!!!");
      Console.WriteLine("Please enter the number of activity you want to do.");
      Console.WriteLine("1. Breathing Activity");
      Console.WriteLine("2. Reflecting Activity");
      Console.WriteLine("3. Listing Activity");
      Console.WriteLine("4. Quit");
      option = int.Parse(Console.ReadLine());
      Console.Clear();

      if (option == 1)
      {
        Breathing breathing = new Breathing();
        breathing.StartMessage();
        breathing.RunActivity();
        breathing.EndMessage();

      }

      else if (option == 2)
      {
        Listing listing = new Listing();
        listing.StartMessage();
        listing.RunActivity();
        listing.EndMessage();
      }

      else if (option == 3)
      {
        Reflecting reflecting = new Reflecting();
        reflecting.StartMessage();
        reflecting.RunActivity();
        reflecting.EndMessage();
      }

      else
      {
        Console.WriteLine("Thank you for working out with Mindfulness program");
        break;
      }
    }
  }
}
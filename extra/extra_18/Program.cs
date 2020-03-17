using System;

namespace extra_18
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
        BirdDatabase db = new BirdDatabase();
        UserInterface ui = new UserInterface(db);
        ui.Start();
    }
  }
}

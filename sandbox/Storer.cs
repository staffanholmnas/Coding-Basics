namespace StreamReader
{
  using System;
  using System.IO;
  public class Storer
  {

    public void WriteToFile(string fileName, string text)
    {
      try
      {
        // Notice the change in the parameters
        StreamWriter writer = new StreamWriter(fileName, true);
        writer.WriteLine(text);
        writer.Close();
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
    }
  }
}
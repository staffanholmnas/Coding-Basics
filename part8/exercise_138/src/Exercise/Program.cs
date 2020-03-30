using System;
using System.Collections.Generic;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Do something here
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("matthew", "matt");
            dict.Add("michael", "mix");
            dict.Add("arthur", "artie");

            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine("{0}'s nickname is {1}", item.Key, item.Value);
            }
        }
    }
}
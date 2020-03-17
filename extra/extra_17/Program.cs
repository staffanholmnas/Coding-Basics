using System;
using System.Collections.Generic;

namespace extra_17
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Identification> idList = new List<Identification>();
            // Add your code here:
            while (true)
            {
                Console.WriteLine("Identifying number?");
                string idNumber = Console.ReadLine();
                if (idNumber == "")
                {
                    break;
                }
                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Identification identification = new Identification(idNumber, name);
                if (!idList.Contains(identification))
                {
                    idList.Add(identification);
                }
            }
            Console.WriteLine("==Persons==");
            foreach (Identification item in idList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

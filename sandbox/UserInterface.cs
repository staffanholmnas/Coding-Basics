using System;
using System.Collections.Generic;

namespace Abstract_Class
{
    public class UserInterface
    {

        private List<Operation> operations;

        public UserInterface()
        {
            this.operations = new List<Operation>();
        }

        public void AddOperation(Operation operation)
        {
            this.operations.Add(operation);
        }

        public void Start()
        {
            while (true)
            {
                PrintOperations();
                Console.WriteLine("Choice: ");

                string choice = Console.ReadLine();
                if (choice == "0")
                {
                    break;
                }

                ExecuteOperation(choice);
                Console.WriteLine();
            }
        }

        private void PrintOperations()
        {
            Console.WriteLine("\t0: Stop");
            int i = 0;
            while (i < this.operations.Count)
            {
                string operationName = this.operations[i].name;
                Console.WriteLine("\t" + (i + 1) + ": " + operationName);
                i = i + 1;
            }
        }

        private void ExecuteOperation(string choice)
        {
            int operation = Convert.ToInt32(choice);

            Operation chosen = this.operations[operation - 1];
            chosen.Execute();
        }
    }
}
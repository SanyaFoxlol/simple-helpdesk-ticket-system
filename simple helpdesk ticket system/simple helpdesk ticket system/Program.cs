using System;
using System.Collections.Generic;

class Program
{
    static List<string> tickets = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1 - Create ticket");
            Console.WriteLine("2 - Show tickets");
            Console.WriteLine("3 - Exit");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter problem: ");
                string problem = Console.ReadLine();

                tickets.Add(problem);
                Console.WriteLine("Ticket created.");
            }

            else if (choice == "2")
            {
                Console.WriteLine("\nTickets:");

                for (int i = 0; i < tickets.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + tickets[i]);
                }
            }

            else if (choice == "3")
            {
                break;
            }
        }
    }
}
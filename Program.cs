using System;

namespace StaticHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.Clear();
            User user1 = new User();
            Console.Write("FullName : ");
            user1.FullName = Console.ReadLine();

            Console.Write("Email: ");
            user1.Email = Console.ReadLine();

            Console.Write("Password: ");
            user1.Password = Console.ReadLine();
                user1.ShowInfo();

            Console.WriteLine("For quit press to esc::");
            Console.WriteLine("For continue press to any key");

            } while (Console.ReadKey().Key!=ConsoleKey.Escape);
        }
    }
}

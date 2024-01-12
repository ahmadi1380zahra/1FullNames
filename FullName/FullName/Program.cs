using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
           

            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            static void Run()
            {
                var option = GetInt("1.add person");
                switch (option)
                {
                    case 1:
                        {
                            var firstName = GetString("Enter First Name");
                            var lastName = GetString("Enter Last Name");
                            FullName.AddFullName(firstName,lastName);
                            break;
                        }
                   
                }
            }
        }
        static string GetString(string message)
        {
            Console.WriteLine(message);
            string value = Console.ReadLine()!;
            return value;
        }

        static int GetInt(string message)
        {
            Console.WriteLine(message);
            int value = int.Parse(Console.ReadLine()!);
            return value;
        }
    }
}

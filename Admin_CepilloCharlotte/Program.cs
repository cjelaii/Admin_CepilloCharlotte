using System;

namespace Admin_CepilloCharlotte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("\nEnter your password: ");
                string password = Console.ReadLine();

                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.WriteLine("\nLogin successful!");

                }

                else
                {
                    Console.WriteLine("\nIncorrect credentials, you have 3 attempts left. Please try again.");

                    Console.WriteLine("\nEnter your username: ");
                    username = Console.ReadLine();

                    Console.WriteLine("\nEnter your password: ");
                    password = Console.ReadLine();

                    if (username == "Admin" && password == "Admin1234!")
                    {
                        Console.WriteLine("\nLogin successful!");
                    }

                    else
                    {
                        Console.WriteLine("\nIncorrect credentials, you have 2 attempts left. Please try again.");

                        Console.WriteLine("\nEnter your username: ");
                        username = Console.ReadLine();

                        Console.WriteLine("\nEnter your password: ");
                        password = Console.ReadLine();
                        if (username == "Admin" && password == "Admin1234!")
                        {
                            Console.WriteLine("\nLogin successful!");
                        }

                        else
                        {
                            Console.WriteLine("Incorrect credentials, you have 1 attempt left. Please try again.");

                            Console.WriteLine("\nEnter your username: ");
                            username = Console.ReadLine();

                            Console.WriteLine("\nEnter your password: ");
                            password = Console.ReadLine();

                            if (username == "Admin" && password == "Admin1234!")
                            {
                                Console.WriteLine("\nLogin successful!");
                            }

                            else
                            {
                                Console.WriteLine(" You have no attempts left please try again later. ");
                            }
                        }
                    }
                }
            }
        }
    }
}
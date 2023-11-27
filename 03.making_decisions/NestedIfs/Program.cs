using System;

namespace NestedIfs;
class Program
{
    static string username;
    static string password;

    static void Main(string[] args)
    {
        bool isAdmin = false;
        bool isRegistered = true;

        Console.WriteLine("Please enter your username : ");
        string userName = "";
        userName = Console.ReadLine();

        if (isRegistered && userName != "" && userName.Equals("admin"))
        {
            Console.WriteLine("Hello there, registerd user");
            //if (userName != "")
            //{
            Console.WriteLine("Hello there, " + userName);
            //if (userName.Equals("admin"))
            //{
            Console.WriteLine("Hello there, Admin");
            //        }
            //    }

        }
        if (isRegistered || isAdmin)
        {
            Console.WriteLine("Hello there, You are registered");
        }

        Register();
        Login();
        Console.Read();
    }

    public static void Register()
    {
        Console.WriteLine("Please enter your username : ");
        username = Console.ReadLine();

        Console.WriteLine("Please enter your password : ");
        password = Console.ReadLine();

        Console.WriteLine("Registration Completed\n-- -- -- -- -- -- -- -- --");
    }

    public static void Login()
    {
        Console.WriteLine("Please enter your username : ");
        if (username == Console.ReadLine())
        {
            Console.WriteLine("Please enter your password : ");
            if (password == Console.ReadLine())
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Login failed, wrong password. Restart program");
            }
        }
        else
        {
            Console.WriteLine("Login failed, wrong username. Restart program");
        }
    }
}

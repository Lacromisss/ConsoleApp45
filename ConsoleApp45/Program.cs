using System;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Fullname, Email, Password;

            Console.WriteLine("Fullname daxil et");
            Fullname = Console.ReadLine();
            Console.WriteLine("E mail daxil edin");
            Email = Console.ReadLine();

            do
            {


                Console.WriteLine("Password daxil edin");
                Password = Console.ReadLine();
            } while (! PasswordChecker(Password));
            User users= new User( Fullname,Email, Password);
            Console.WriteLine(users.ShowInfo());





        }
        static bool  PasswordChecker(string password)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            if (!string.IsNullOrWhiteSpace(password) && password.Length > 8)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (char.IsDigit(password[i]))
                        hasDigit = true;
                    else if (char.IsLower(password[i]))
                        hasLower = true;
                    else if (char.IsUpper(password[i]))
                        hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                        return true;
                }
            }

            return false;
        }
    }
    }


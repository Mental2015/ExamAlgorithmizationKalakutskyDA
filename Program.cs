using System;
using System.Linq;

namespace EXAMEN
{
    internal class Program
    {
        private static bool CheckPassword(string password)
        {
            if (password.Length < 8 && password.Length > 20)
                    return false;
            if (!password.Any(char.IsDigit))
                return false;
            if (!password.Any(char.IsLower))
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(c => "!@#$%^&*()".Contains(c)))
                return false;
            return true;
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Ввидите парол: ");
                string password = Console.ReadLine();
                if (CheckPassword(password))
                {
                    Console.WriteLine("Пароль верен.");
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль не верен.");
                }       
            }
        }
    }
}
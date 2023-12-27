using System;

namespace Intro.Lesson2
{
    internal class UserAuthentication
    {
        public static void Main(string[] args) {
            Console.WriteLine("Please enter your username ...");
            string? uncheckedUsername = Console.ReadLine();
            string userName = uncheckedUsername ?? "";

            Console.WriteLine("Please enter your password ...");
            string? unchedPassword = Console.ReadLine();
            string password = unchedPassword ?? "";

            string message = IsAuthenticated(userName, password) ? "Welcome!" : "Invalid username or password";
            Console.WriteLine(message);
        }

        static bool IsAuthenticated(string username, string password) {
            const string _password = "password";
            const string _username = "username";

            username = username.ToLower();

            return username == _username && password == _password;
        }
    }
}

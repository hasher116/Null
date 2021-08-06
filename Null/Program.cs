using System;

namespace Null
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "andrew";
            string z = name ?? "vasya";
            Console.WriteLine(z);

            User user = new User();
            string companyName = user?.Phone?.Company?.Name ?? "не установлено";
            Console.WriteLine(companyName);
        }
    }
}

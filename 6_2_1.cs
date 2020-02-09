//1.	כתוב תוכנית הקולטת n  מספרים ומדפיסה עבור כל מספר את ערכו ואת ערכו הריבועי
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
                Console.WriteLine("enter number");
                int b =int.Parse(Console.ReadLine());
                for ( int a = 0; b > a; a++)
                {
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine(c);
                    Console.WriteLine(Math.Pow(2, c));
            }
        }
    }
}

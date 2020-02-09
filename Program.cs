//2.	כתוב תוכנית הקולטת מהמשתמש 10 מספרים שלמים והצג כמה מספרים שהוקלדו אי-זוגיים
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int d = 0;
            for (int a = 0; 10 > a; a++)
            {
                int c = int.Parse(Console.ReadLine());

                if (c % 2 == 0)
                {

                }
                else
                {
                    d++;
                }
            }
            Console.WriteLine(d);
        }
    }
}

using System;
namespace inlämningsuppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gränsen för att hyra bil är vid 950kr!");
            Console.WriteLine("Hur många timmar vill du hyra bilen?: ");
            string x = Console.ReadLine();
            int y = Convert.ToInt32(x);
            int hyra = 80 * y;
            int maxhyra = 950;
            Console.Clear();
            if (hyra >= maxhyra)
            {
                Console.WriteLine("Du har nått max gränsen");
            }
            else
            {
                Console.WriteLine("Det totala priset för antal timmar blir: " + hyra + "kr");
            }
        }
    }
}
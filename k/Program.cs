using System;

namespace k
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            string svar1;
            int tal;

            Console.WriteLine("Hej vem är du?");
            name = Console.ReadLine();
            Console.WriteLine("välkommen " + name);
            Console.WriteLine("DET ÄR dags för sänka skepp på ett led.");
            Console.WriteLine("Datorn tänker på ett tall mellan 1 och 10, du ska själv gissa vilket.");
            Console.WriteLine("Vilken siffra väljer du?");
            svar1 = Console.ReadLine();
            while (svar1 != "1" && svar1 != "2" && svar1 != "4" && svar1 != "5" && svar1 != "6" && svar1 != "7" && svar1 != "8" && svar1 != "9" && svar1 != "10")
            {
                Console.WriteLine("Gärna en siffra mellan 1 och 10 tack");
                svar1 = Console.ReadLine();
            }
            bool kovert = int.TryParse(svar1, out tal);
            if (tal < 3 || tal > 3)
            {
                Console.WriteLine("Det är inte en träff, försök igen");
                svar1 = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("grattis, det är en träff");
                Console.ReadLine();
            }


        }
    }
}
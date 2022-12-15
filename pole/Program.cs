using System;

namespace pole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] simpsonovi = { "Homer", "Marge", "Bart", "Lisa", "Maggie" };
            Array.Sort(simpsonovi);
            foreach (string serazeno in simpsonovi)
                Console.WriteLine("{0}", serazeno);
            Console.ReadKey();



        }
    }
}

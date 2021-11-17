using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Book WarAndPeace = new Book { Title = "War And Peace" } ;
            Console.WriteLine(WarAndPeace);
            WarAndPeace.IncreaseEditionNumber();
            Console.WriteLine(WarAndPeace);
        }
    }
}

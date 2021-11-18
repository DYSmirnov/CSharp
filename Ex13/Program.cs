using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            Book WarAndPeace = new Book { Title = "Война и Мир", Autor = "Толстой Лев Николаевич" } ;
            Console.WriteLine(WarAndPeace);
            WarAndPeace.IncreaseEditionNumber();
            Book GenerationP = new Book { Title = "Поколение П", Autor = "Пелевин Виктор Олегович" };
            Book Compromise = new Book { Title = "Компромисс", Autor = "Довлатов Сергеей Донаатович" };
            Book Suitcase = new Book { Title = "Чемодан", Autor = "Довлатов Сергеей Донаатович" };
            Console.WriteLine(WarAndPeace);
            Console.WriteLine(GenerationP);
            Console.WriteLine(Compromise);
            Console.WriteLine(Suitcase.CompareTo(Compromise));

        }
    }
}

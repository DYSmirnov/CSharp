using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetDigFromUser();
            SimpleNumbers(num);
        }
        
        static int GetDigFromUser()
        {
            Console.WriteLine("Enter digit");
            int dig = int.Parse(Console.ReadLine());
            return dig;
        }

        static void SimpleNumbers(int numb)
         {
            int t_f;
            t_f = 1;
            if (numb > 0 & numb <3)
                t_f = 1; 
            else if (numb < 1)
                t_f = 0;
                
            else
            for (int i = 2; i < numb; i++) 
            {
                if (numb % i == 0)
                    t_f = 2;

            }
            
            Res(t_f);
        }
        static void Res(int tf)
        {
            if (tf == 0)
                Console.WriteLine("Incorrect digit");
            else if (tf == 1)
                Console.WriteLine("This is simple digit");
            else
                Console.WriteLine("This is not simple digit");
        }
    }
}

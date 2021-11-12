using System;
using System.Collections;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Смирнов");
            list.Add("Петров");
            list.Add("Носов");
            list.Add("Чижиков");
            Console.Write("Enter last name: ");
            string ln = Console.ReadLine();
            if (list.Contains(ln) == true) { Console.Write(list.IndexOf(ln)+1); Console.Write(": "); Console.Write(ln);  }
            else { list.Add(ln); Out(list); }

        }
        static void Out(ArrayList list) 
        {
            int c = 0;
            foreach (object o in list) 
            {
                c++;
                if (c == list.Count)
                {
                    Console.Write(o);
                }
                else
                {
                    Console.Write(o);
                    Console.Write(", ");
                }

            } 
        }
    }
}

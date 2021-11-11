using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector();
                v.Append(-5);
                v.Append(4.8);
            v.Append(100);
            Console.WriteLine(v);
        }
    }
}

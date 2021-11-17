using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {

            Vector v = new Vector();
            Vector v1 = new Vector();
            v.Append(5);
            v.Append(4.8);
            v.Append(100);
            v1.Append(5);
            v1.Append(4.8);
            v1.Append(100);
            Vector v2 = new Vector();
            v2 = v1.Divide(2);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v.GetElementAt(2));
        }
    }
}

using System;
using System.Collections;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dig = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            char[] symb = "АВСЕНКМОРТХ".ToCharArray();
            ArrayList number = new ArrayList();
            number.Add(symb[RandSymb(symb)]);
            number.Add(RandDig(dig));
            number.Add(RandDig(dig));
            number.Add(RandDig(dig));
            number.Add(symb[RandSymb(symb)]);
            number.Add(symb[RandSymb(symb)]);
            foreach (object o in number)
            {
                Console.Write(o);
            }

        }
        static int RandDig(int[] d)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, d.Length);
            return d[index];
        }
        static int RandSymb(char[] s)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, s.Length);
            return index;
        }
    }
}

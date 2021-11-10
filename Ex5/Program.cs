using System;
using System.Collections;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Jan = new int[31];
            int[] Feb1 = new int[28];
            int Feb2 = 29;
            int[] Mar = new int[31];
            int[] Apr = new int[30];
            int[] May = new int[31];
            int[] Jun = new int[30];
            int[] Jul = new int[31];
            int[] Aug = new int[31];
            int[] Sep = new int[30];
            int[] Oct = new int[31];
            int[] Nov = new int[30];
            int[] Dec = new int[31];
            Jan = Month(Jan);
            Feb1 = Month(Feb1);
            Mar = Month(Mar);
            Apr = Month(Apr);
            May = Month(May);
            Jun = Month(Jun);
            Jul = Month(Jul);
            Aug = Month(Aug);
            Sep = Month(Sep);
            Oct = Month(Oct);
            Nov = Month(Nov);
            Dec = Month(Dec);
            Year(Jan,1);
            Year(Feb1,2);
            Year(Mar,3);
            Year(Apr,4);
            Year(May,5);
            Year(Jun,6);
            Year(Jul,7);
            Year(Aug,8);
            Year(Sep,9);
            Year(Oct,10);
            Year(Nov,11);
            Year(Dec,12);
            LeapYear(Feb2);

        }
        static int[] Month(int[] mon)
        {
            for (int i = 1; i < mon.Length + 1; i++)
                mon[i - 1] = i;
            return mon;
        }
        static void Year(int[] mon, int MonNumb)
        {
            for (int i = 0; i < 100; i++)
                foreach (int month in mon)
                    if ((month * MonNumb) == i)
                    {
                        Console.Write(String.Format(month.ToString("D2")));
                        Console.Write("."); Console.Write(String.Format(MonNumb.ToString("D2")));
                        Console.Write(".2"); Console.Write(String.Format(i.ToString("D3"))); Console.Write("\n");
                    }
        }
            static void LeapYear(int month)
            {
                for (int i = 0; i < 100; i = i + 4)
                    if ((month * 2) == i)
                    {
                        Console.Write(String.Format(month.ToString("D2")));
                        Console.Write(".02.2");
                        Console.Write(String.Format(i.ToString("D3"))); Console.Write("\n");
                }
            }
        }
    }

////foreach (int mon in Jan)
////     for (int i = 0; i < 100; i++)
////         if (mon == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".01.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Feb1)
////     for (int i = 0; i < 100; i++)
////         if (mon*2 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".02.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Mar)
////     for (int i = 0; i < 100; i++)
////         if (mon * 3 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".03.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Apr)
////     for (int i = 0; i < 100; i++)
////         if (mon * 4 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".04.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in May)
////     for (int i = 0; i < 100; i++)
////         if (mon * 5 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".05.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Jun)
////     for (int i = 0; i < 100; i++)
////         if (mon * 6 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".06.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Jul)
////     for (int i = 0; i < 100; i++)
////         if (mon * 7 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".06.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Aug)
////     for (int i = 0; i < 100; i++)
////         if (mon * 8 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".08.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Sep)
////     for (int i = 0; i < 100; i++)
////         if (mon * 9 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".09.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Oct)
////     for (int i = 0; i < 100; i++)
////         if (mon * 10 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".10.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Nov)
////     for (int i = 0; i < 100; i++)
////         if (mon * 11 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".11.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
//// foreach (int mon in Dec)
////     for (int i = 0; i < 100; i++)
////         if (mon * 12 == i)
////         {
////             Console.Write(String.Format(mon.ToString("D2")));
////             Console.Write(".12.2");
////             Console.WriteLine(String.Format(i.ToString("D3")));
////         }
using System;


namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetDigFromUser();
            Convert(num);
        }
        static int GetDigFromUser()
        {
            Console.WriteLine("Enter digit");
            int dig = int.Parse(Console.ReadLine());
            return dig;
        }

        static void Convert(int dig) //string
        {
            if (dig <= 3 && dig > 0)
            {
                string str = "I";
                for (int i = 1; i <= dig; i++) { Console.Write(str); };
            }
            if (dig > 3 && dig < 9)
            {
                if (dig <= 5)
                {
                    string str = "V";
                    int new_dig = Math.Abs(dig - 5);
                    Convert(new_dig);
                    Console.Write(str);
                }
                else if (dig > 5)
                {
                    string str = "V";
                    int new_dig = Math.Abs(dig - 5);
                    Console.Write(str);
                    Convert(new_dig);
                }
            }
                if (dig > 8 && dig < 40)
                {
                    if (dig <= 10)
                    {
                        string str = "X";
                        int new_dig = Math.Abs(dig - 10);
                        Convert(new_dig);
                        Console.Write(str);
                    }
                    else if (dig > 10)
                    {
                        string str = "X";
                        int new_dig = Math.Abs(dig - 10);
                        Console.Write(str);
                        Convert(new_dig);
                    }
                }
            if (dig > 39 && dig < 90)
            {
                if (dig <= 50)
                {
                    string str = "L";
                    int new_dig = Math.Abs(dig - 50);
                    Convert(new_dig);
                    Console.Write(str);
                }
                else if (dig > 50)
                {
                    string str = "L";
                    int new_dig = Math.Abs(dig - 50);
                    Console.Write(str);
                    Convert(new_dig);
                }
            }
            if (dig > 89 && dig < 400)
            {
                if (dig <= 100)
                {
                    string str = "C";
                    int new_dig = Math.Abs(dig - 100);
                    Convert(new_dig);
                    Console.Write(str);
                }
                else if (dig > 100)
                {
                    string str = "C";
                    int new_dig = Math.Abs(dig - 100);
                    Console.Write(str);
                    Convert(new_dig);
                }
            }
            if (dig > 399 && dig < 900)
            {
                if (dig <= 500)
                {
                    string str = "D";
                    int new_dig = Math.Abs(dig - 500);
                    Convert(new_dig);
                    Console.Write(str);
                }
                else if (dig > 500)
                {
                    string str = "D";
                    int new_dig = Math.Abs(dig - 500);
                    Console.Write(str);
                    Convert(new_dig);
                }
            }
            if (dig > 899 )
            {
                if (dig <= 1000)
                {
                    string str = "M";
                    int new_dig = Math.Abs(dig - 1000);
                    Convert(new_dig);
                    Console.Write(str);
                }
                else if (dig > 1000)
                {
                    string str = "M";
                    int new_dig = Math.Abs(dig - 1000);
                    Console.Write(str);
                    Convert(new_dig);
                }
            }
        }
        }
    }


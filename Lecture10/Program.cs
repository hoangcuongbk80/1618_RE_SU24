using System;

namespace Lecture10
{
    internal class Program
    {
        static string ModifyText(string text)
        {
            string new_text = text + "@fpt.edu.vn";
            return new_text;
        }
        static void PrintText(string text)
        {
            Console.WriteLine("--------pintText------");
            string new_text = ModifyText(text);
            Console.WriteLine(new_text);
            Console.WriteLine("--------Finish--------");
        }
        static void PrintNumbers(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}", i);
            }
        }
        static void PrintSign(int number)
        {
            if (number > 0)
                Console.WriteLine("The number {0} is positive", number);
            else if (number < 0)
                Console.WriteLine("The number {0} is negative.", number);
            else
                Console.WriteLine("The number {0} is zero.", number);
        }

        static void PrintGradeWord(double  grade=5.8)   
        {
            if (grade >= 2.0 && grade < 2.99)
                Console.WriteLine("Fail");
            if (grade >= 3.0 && grade < 3.49)
                Console.WriteLine("Poor");
            if (grade >= 3.5 && grade < 4.49)
                Console.WriteLine("Good");
            if (grade >= 4.5 && grade < 5.49)
                Console.WriteLine("Very Good");
            if (grade >= 5.5 && grade < 6.0)
                Console.WriteLine("Excellent");
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
                PrintLine(1, line);

            for (int line = n - 1; line >= 1; line--)
                PrintLine(1, line);
        }

        static int GetMax(int a, int b)
        {
            if (a >= b) return a;
            else return b;    
        }

        static char GetMax(char c1, char c2)
        {
            if (c1 >= c2) return c1;
            else return c2;
        }

        static string GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) > 0)
                return str1;
            else return str2;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while(num > 0)
            {
                int a = num % 10;
                if (a % 2 != 0)
                    sum += a;
                num = num / 10;
            }
            return sum;        }
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int a = num % 10;
                if (a % 2 == 0 )
                    sum += a;
                num = num / 10;
            }
            return sum;
        
        }

        static int GetMultipleOfEvensAndOdds(int num)
        {
            return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
        }
        static void Main(string[] args)
        {
            //PrintText("cuonghd12");

            //PrintNumbers(10,20);

            /*int num = int.Parse(Console.ReadLine());
            PrintSign(num);*/

            /*PrintGradeWord(4.3);
            PrintGradeWord();*/

            // PrintTriangle(4);

            /*string data_type = Console.ReadLine();
            if (data_type == "int")
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            else if (data_type == "char")
            {
                char c1 = Convert.ToChar(Console.ReadLine());
                char c2 = Convert.ToChar(Console.ReadLine());
                char max = GetMax(c1, c2);
                Console.WriteLine(max);
            }
            else if (data_type == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                string max = GetMax(str1, str2);
                Console.WriteLine(max);
            }*/

            /*int num = int.Parse(Console.ReadLine());
            int pos_num = Math.Abs(num);
            int result = GetMultipleOfEvensAndOdds(pos_num);
            Console.WriteLine(result);*/

        }
    }
}

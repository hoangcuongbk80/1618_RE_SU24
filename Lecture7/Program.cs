using System;
using System.Diagnostics;

namespace Lecture7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Lecture 7------------");

            /*int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num_max = int.MinValue;
            Console.WriteLine(num_max);
            if(num1 > num_max)
                num_max = num1;
            if (num2 > num_max)
                num_max = num2;
            if (num3 > num_max)
                num_max = num3;*/

            /*int[] num = new int[5];
            for(int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int num_max = int.MinValue;
            for(int i = 0;i < num.Length;i++)
            {
                if (num[i] > num_max) 
                    num_max = num[i];
            }
            Console.WriteLine("Max: {0}", num_max);*/

            /*string values = Console.ReadLine();
            string[] items = values.Split(" ");
            int[] numbers = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
                numbers[i] = int.Parse(items[i]);
            int num_max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > num_max)
                    num_max = numbers[i];
            }
            Console.WriteLine("Max: {0}", num_max);*/

            // Sorting numbers
            /*string values = Console.ReadLine();
            string[] items = values.Split(" ");
            int[] numbers = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
                numbers[i] = int.Parse(items[i]);
            int num_max = int.MinValue;
            int[] ordered_numbers = new int[items.Length];
            Console.WriteLine("Before sorting: ");
            foreach (var num in numbers)
            {
                Console.Write("{0} ", num);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                num_max = int.MinValue;
                int index_max=0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] > num_max)
                    {
                        index_max = j;
                        num_max = numbers[j];
                    }
                }
                ordered_numbers[i] = numbers[index_max];
                numbers[index_max] = int.MinValue;
            }
            Console.WriteLine("\nAfter sorting: ");
            foreach(var num in numbers)
            {
                Console.Write("{0} ", num);
            }*/


        }
    }
}

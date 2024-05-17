namespace Lecture4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string outer = "I'm inside the Main()";
            Console.WriteLine(outer);
            for (int i = 0; i < 10; i++)
            {
                string inner = "I'm inside the loop";
                Console.WriteLine(inner);
            }*/

            /*int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 =int.Parse(Console.ReadLine());
            double result = ((double)(num1 + num2) / num3) * num4;
            Console.WriteLine(result);*/

            /*Decimal a = 3.0M;
            Decimal b = 0.00000000000000000001M;
            bool result = (a+b)>3.0M;
            Console.WriteLine(result);*/

            /*string name = "Hoang\nCuong";
            Console.WriteLine(name);
            name = "Hoang\\nCuong";
            Console.WriteLine(name);
            name = @"Hoang\nCuong";
            Console.WriteLine(name);*/

            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int? result;
            if (b == 0) result = null;
            else result = a / b;
            if(result != null)
            {
                Console.WriteLine(result);
            }*/

            var a = 8 / 3;
            var b = 'A';
            var c = "Cuong";
            var d = 29;
            var f = 1 > 0;
        }
    }
}

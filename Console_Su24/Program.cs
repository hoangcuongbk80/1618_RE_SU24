namespace Console_Su24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            Console.WriteLine("--------- Example 1 ----------");
            Console.Write("Hello, ");
            Console.WriteLine("FGW students");
            Console.WriteLine("I am Cuong");

            // Example 2
            Console.WriteLine("--------- Example 1 ----------");
            Console.Write("What is your first name: ");
            string first_name = Console.ReadLine();
            Console.Write("What is your last name: ");
            string last_name = Console.ReadLine();
            string full_name = first_name + " " + last_name;
            Console.Write("Birth year:");
            int birth_year = Convert.ToInt32(Console.ReadLine());
            int age = 2024 - birth_year;
            Console.Write("Your address: ");
            string address = Console.ReadLine();
            Console.Write("Your income before taxes: ");
            double income = 0.9 * Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Info: {0}, {1} years old, live in {2}, " 
            + "income after taxes {3}", full_name, age, address, income);
        }
    }
}

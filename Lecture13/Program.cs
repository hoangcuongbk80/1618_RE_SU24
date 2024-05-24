using System.Globalization;
using System.Numerics;


namespace Lecture13
{
    public class Teacher
    {
        public string name;
        public List<string> courses;
        public int salary;

        //constructor
        public Teacher()
        {
            Console.WriteLine("A new object of teacher class is created without intial info.");
        }
        public Teacher(string name)
        {
            this.name = name;
            courses = new List<string>();
        }

        public void GoToTeach(string course)
        {
            Console.WriteLine($"Teacher is teaching: {course}");
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Lecture 13--------");

            /*var day = new DateTime(2024, 1, 12);
            Console.WriteLine(day);

            string dateAsText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy",
              CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);*/

            /*DateTime today = DateTime.Now;
            Console.WriteLine("Today: {0}", today);
            double cosine = Math.Cos(Math.PI);
            Console.WriteLine("Cos({0})={1}", Math.PI, cosine);
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 99);
            Console.WriteLine("Random number: {0}", randomNumber);*/

            /*string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                string temp = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));*/

            /*int n = int.Parse(Console.ReadLine());
            BigInteger f = 1;
            for (int i = 2; i <= n; i++)
                f *= i;
            Console.WriteLine(f);*/


            Teacher teacher1 = new Teacher("Hoang Cuong");
            teacher1.salary = 1000;
            teacher1.courses.Add("C#");
            teacher1.courses.Add("Python");
            teacher1.courses.Add("Java");
            Console.WriteLine("Name: {0}, Salary: {1}", teacher1.name, teacher1.salary);
            foreach (string s in teacher1.courses) Console.WriteLine(s);
            teacher1.GoToTeach(teacher1.courses[0]);


        }
    }
}

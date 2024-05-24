namespace Lecture16
{
    class Person
    {
        public string name;
        public int age;
        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;   
        }
        public override string ToString()
        {
            return $"{name}, {age} years old";
        }
    }
    class Student : Person 
    {
        public  string school;
        public Student(string name, int age, string school) : base(name, age)
        {
            this.school = school;
        }
        public override string ToString()
        {
            return $"{name}, {age} years old, study at {school}";
        }
    }

    class Employee : Person
    {
        public  string company;
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
        }
    }
    
    
    internal class Program
    {
        public static void Menu()
        {
            Console.WriteLine("-------------Menu:------------");
            Console.WriteLine("0->add a new student");
            Console.WriteLine("1->remove a student");
            Console.WriteLine("2->print all current students");
            Console.WriteLine("3->sort students");
            Console.WriteLine("4->exit");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("------------Lecture 16--------------");

            Console.Write("Enter number of students: ");
            var n = int.Parse(Console.ReadLine());
            var students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student  {0}: ", i);
                var input = Console.ReadLine().Split(" ");
                string name = input[0];
                int age = int.Parse(input[1]);
                string school = input[2];

                Student student = new Student(name, age, school);
                students.Add(student);
            }

            bool finish = false;
            Menu();

            while (finish != true)
            {
                Console.Write("\nEnter your option (0-3): ");
                int option = int.Parse(Console.ReadLine());
                switch(option) 
                {
                    case 0:
                        Console.WriteLine("Enter a new student: ");
                        var input = Console.ReadLine().Split(" ");
                        string name = input[0];
                        int age = int.Parse(input[1]);
                        string school = input[2];

                        Student student = new Student(name, age, school);
                        students.Add(student);
                        break;

                    case 1:
                        Console.WriteLine("Enter student position where you want to remove: ");
                        int pos = int.Parse(Console.ReadLine());
                        students.RemoveAt(pos); 
                        break;
                    case 2:
                        Console.WriteLine("\nInfo of all students: ");
                        foreach (Student stu in students)
                        {
                            Console.WriteLine(stu.ToString());
                        }
                        break;
                    case 3:
                        var students_sorted = students.OrderBy(p => p.name).ThenBy(p => p.age).ToList();
                        Console.WriteLine("\nInfo of all students after sorting: ");
                        foreach (Student stu in students_sorted)
                        {
                            Console.WriteLine(stu.ToString());
                        }
                        break;
                    case 4:
                        finish = true;
                        break;
                    default:
                        Console.WriteLine("Please only enter a number from 0 to 4");
                        Menu();
                        break;
                }
            }
        }
    }
}

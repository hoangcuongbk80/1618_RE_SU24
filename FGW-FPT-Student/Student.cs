using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGW_FPT_Student
{
    public class Student : Person
    {
        private int id;
        private string email;
        private string courses;
        public Student(string name, int id) : base(name)
        {
            id = this.id;
        }
        public int ID { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Courses { get { return courses; } set { courses = value; } }
        public override string ToString()
        {
            string info = this.name + ", " + this.id.ToString() + ", " + this.email + ", " + this.courses;
            return info;
        }

    }
}

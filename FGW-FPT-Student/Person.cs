using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGW_FPT_Student
{
    public class Person
    {
        public string name;
        private int age;
        private string addess;
        public Person(string name) 
        {
            this.name = name;
        }

        public int Age {  get { return age; } set {  age = value; } }
        public string Address { get { return addess; } set { addess = value; } }

        public override string ToString()
        {
            string info = name + " " + age + " " + addess;
            return info;
        }
    }
}

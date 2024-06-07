using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace FGW_FPT_Student
{
    public partial class Form2 : Form
    {
        DataTable table = new DataTable("table");
        List<Student> students = new List<Student>();

        public Form2()
        {
            InitializeComponent();
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Name", Type.GetType("System.String"));
            table.Columns.Add("Email", Type.GetType("System.String"));
            table.Columns.Add("Courses", Type.GetType("System.String"));

            dataGridView1.DataSource = table;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            string email = tb_email.Text;
            string courses = tb_courses.Text;

            Student student = new Student(name, id);
            students.Add(student);

            DataRow newRow = table.NewRow();
            newRow["ID"] = id;
            newRow["Name"] = name; student.Email = email;
            newRow["Email"] = email;
            newRow["Courses"] = courses; student.Courses = courses;

            table.Rows.Add(newRow);
            richTextBox1.Text += "Added a new student: " + student.ToString() + "\n";

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            students.RemoveAt(index);
            dataGridView1.Rows.RemoveAt(index);
        }

        private void bt_SaveFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("students.txt"))
            {
                for (int i = 0; i < students.Count; i++)
                {
                    string stu_info = students[i].ToString();
                    writetext.WriteLine(stu_info);
                }
            }
        }

        private void bt_OpenFile_Click(object sender, EventArgs e)
        {
            using (StreamReader readtext = new StreamReader("students.txt"))
            {
                String line;
                while ((line = readtext.ReadLine()) != null)
                {
                    richTextBox1.Text += line + "\n";
                    string[] info = line.Split(" | ");

                    string name = info[0];
                    int id = Convert.ToInt32(info[1]);
                    string email = info[2];
                    string courses = info[3];

                    Student student = new Student(name, id);
                    students.Add(student);

                    DataRow newRow = table.NewRow();
                    newRow["ID"] = id;
                    newRow["Name"] = name; student.Email = email;
                    newRow["Email"] = email;
                    newRow["Courses"] = courses; student.Courses = courses;

                    table.Rows.Add(newRow);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGW_FPT_Student
{
    public partial class Form2 : Form
    {
        DataTable table = new DataTable("table");

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
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}

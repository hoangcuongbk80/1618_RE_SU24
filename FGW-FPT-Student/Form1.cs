namespace FGW_FPT_Student
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();

        public Form1()
        {
            InitializeComponent();
            this.tb_password.PasswordChar = '*';

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(this.tb_username.Text == "cuonghd7")
            {
                if(tb_password.Text == "123")
                {
                    MessageBox.Show(this.comboBox1.Text + "Login successfully!");
                    if(this.comboBox1.Text == "Admin")
                        this.form2.Show();
                    if(this.comboBox1.Text == "Student")
                        this.form3.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid user name or password");
            }
        }
    }
}

namespace FGW_FPT_Student
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            bt_Add = new Button();
            tb_id = new TextBox();
            tb_email = new TextBox();
            tb_name = new TextBox();
            tb_courses = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Remove = new Button();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            bt_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1208, 627);
            dataGridView1.TabIndex = 0;
            // 
            // bt_Add
            // 
            bt_Add.BackColor = Color.DarkSeaGreen;
            bt_Add.Location = new Point(21, 294);
            bt_Add.Name = "bt_Add";
            bt_Add.Size = new Size(188, 58);
            bt_Add.TabIndex = 1;
            bt_Add.Text = "Add";
            bt_Add.UseVisualStyleBackColor = false;
            bt_Add.Click += bt_Add_Click;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(344, 85);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(250, 47);
            tb_id.TabIndex = 2;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(21, 195);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(251, 47);
            tb_email.TabIndex = 3;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(21, 85);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(250, 47);
            tb_name.TabIndex = 4;
            // 
            // tb_courses
            // 
            tb_courses.Location = new Point(344, 195);
            tb_courses.Name = "tb_courses";
            tb_courses.Size = new Size(250, 47);
            tb_courses.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 41);
            label2.Name = "label2";
            label2.Size = new Size(47, 41);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 151);
            label3.Name = "label3";
            label3.Size = new Size(88, 41);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 151);
            label4.Name = "label4";
            label4.Size = new Size(124, 41);
            label4.TabIndex = 9;
            label4.Text = "Courses";
            // 
            // Remove
            // 
            Remove.BackColor = Color.Goldenrod;
            Remove.Location = new Point(473, 294);
            Remove.Name = "Remove";
            Remove.Size = new Size(188, 58);
            Remove.TabIndex = 10;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(1226, 97);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(609, 904);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1226, 53);
            label5.Name = "label5";
            label5.Size = new Size(112, 41);
            label5.TabIndex = 12;
            label5.Text = "History";
            // 
            // bt_Search
            // 
            bt_Search.BackColor = Color.LightPink;
            bt_Search.Location = new Point(250, 294);
            bt_Search.Name = "bt_Search";
            bt_Search.Size = new Size(188, 58);
            bt_Search.TabIndex = 13;
            bt_Search.Text = "Search";
            bt_Search.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1847, 1013);
            Controls.Add(bt_Search);
            Controls.Add(label5);
            Controls.Add(richTextBox1);
            Controls.Add(Remove);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_courses);
            Controls.Add(tb_name);
            Controls.Add(tb_email);
            Controls.Add(tb_id);
            Controls.Add(bt_Add);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button bt_Add;
        private TextBox tb_id;
        private TextBox tb_email;
        private TextBox tb_name;
        private TextBox tb_courses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Remove;
        private RichTextBox richTextBox1;
        private Label label5;
        private Button bt_Search;
    }
}
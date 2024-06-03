namespace FGW_FPT_Student
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tb_username = new TextBox();
            tb_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bt_login = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(450, 266);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(338, 47);
            tb_username.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(450, 380);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(338, 47);
            tb_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 266);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 2;
            label1.Text = "User name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 380);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.DarkOrange;
            bt_login.Location = new Point(450, 501);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(277, 58);
            bt_login.TabIndex = 4;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Student", "Admin" });
            comboBox1.Location = new Point(450, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 49);
            comboBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(347, 159);
            label3.Name = "label3";
            label3.Size = new Size(76, 41);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1362, 824);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(bt_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_password);
            Controls.Add(tb_username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_password;
        private Label label1;
        private Label label2;
        private Button bt_login;
        private ComboBox comboBox1;
        private Label label3;
    }
}

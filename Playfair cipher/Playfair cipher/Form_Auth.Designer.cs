namespace Playfair_cipher
{
    partial class Form_Auth
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.button_Registration = new System.Windows.Forms.Button();
            this.button_Inter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Complete_Reg = new System.Windows.Forms.Button();
            this.label_Password_Repeated = new System.Windows.Forms.Label();
            this.textBox_Password_Repeated = new System.Windows.Forms.TextBox();
            this.button_Cancel_Reg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(12, 21);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(178, 23);
            this.textBox_Login.TabIndex = 1;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(12, 65);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(178, 23);
            this.textBox_Password.TabIndex = 2;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(80, 3);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(41, 15);
            this.label_Login.TabIndex = 3;
            this.label_Login.Text = "Логин";
            this.label_Login.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button_Registration
            // 
            this.button_Registration.Location = new System.Drawing.Point(12, 123);
            this.button_Registration.Name = "button_Registration";
            this.button_Registration.Size = new System.Drawing.Size(178, 23);
            this.button_Registration.TabIndex = 5;
            this.button_Registration.Text = "Регистрация";
            this.button_Registration.UseVisualStyleBackColor = true;
            this.button_Registration.Click += new System.EventHandler(this.Button_Registration_Click);
            // 
            // button_Inter
            // 
            this.button_Inter.Location = new System.Drawing.Point(12, 94);
            this.button_Inter.Name = "button_Inter";
            this.button_Inter.Size = new System.Drawing.Size(178, 23);
            this.button_Inter.TabIndex = 0;
            this.button_Inter.Text = "Вход";
            this.button_Inter.UseVisualStyleBackColor = true;
            this.button_Inter.Click += new System.EventHandler(this.Button_Inter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Пароль";
            // 
            // button_Complete_Reg
            // 
            this.button_Complete_Reg.Location = new System.Drawing.Point(12, 138);
            this.button_Complete_Reg.Name = "button_Complete_Reg";
            this.button_Complete_Reg.Size = new System.Drawing.Size(178, 23);
            this.button_Complete_Reg.TabIndex = 6;
            this.button_Complete_Reg.Text = "Зарегистрироваться";
            this.button_Complete_Reg.UseVisualStyleBackColor = true;
            this.button_Complete_Reg.Visible = false;
            this.button_Complete_Reg.Click += new System.EventHandler(this.Button_Complete_Reg_Click);
            // 
            // label_Password_Repeated
            // 
            this.label_Password_Repeated.AutoSize = true;
            this.label_Password_Repeated.Location = new System.Drawing.Point(46, 91);
            this.label_Password_Repeated.Name = "label_Password_Repeated";
            this.label_Password_Repeated.Size = new System.Drawing.Size(109, 15);
            this.label_Password_Repeated.TabIndex = 7;
            this.label_Password_Repeated.Text = "Повторите пароль";
            this.label_Password_Repeated.Visible = false;
            // 
            // textBox_Password_Repeated
            // 
            this.textBox_Password_Repeated.Location = new System.Drawing.Point(12, 109);
            this.textBox_Password_Repeated.Name = "textBox_Password_Repeated";
            this.textBox_Password_Repeated.PasswordChar = '*';
            this.textBox_Password_Repeated.Size = new System.Drawing.Size(178, 23);
            this.textBox_Password_Repeated.TabIndex = 8;
            this.textBox_Password_Repeated.Visible = false;
            // 
            // button_Cancel_Reg
            // 
            this.button_Cancel_Reg.Location = new System.Drawing.Point(12, 167);
            this.button_Cancel_Reg.Name = "button_Cancel_Reg";
            this.button_Cancel_Reg.Size = new System.Drawing.Size(178, 23);
            this.button_Cancel_Reg.TabIndex = 9;
            this.button_Cancel_Reg.Text = "Отмена";
            this.button_Cancel_Reg.UseVisualStyleBackColor = true;
            this.button_Cancel_Reg.Visible = false;
            this.button_Cancel_Reg.Click += new System.EventHandler(this.Button_Cancel_Reg_Click);
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 153);
            this.Controls.Add(this.button_Cancel_Reg);
            this.Controls.Add(this.textBox_Password_Repeated);
            this.Controls.Add(this.label_Password_Repeated);
            this.Controls.Add(this.button_Complete_Reg);
            this.Controls.Add(this.button_Registration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.button_Inter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Auth";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox_Login;
        private TextBox textBox_Password;
        private Label label_Login;
        private Button button_Registration;
        private Button button_Inter;
        private Label label1;
        private Button button_Complete_Reg;
        private Label label_Password_Repeated;
        private TextBox textBox_Password_Repeated;
        private Button button_Cancel_Reg;
    }
}
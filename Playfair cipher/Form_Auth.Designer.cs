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
            this.button_Inter = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Inter
            // 
            this.button_Inter.Location = new System.Drawing.Point(12, 94);
            this.button_Inter.Name = "button_Inter";
            this.button_Inter.Size = new System.Drawing.Size(100, 23);
            this.button_Inter.TabIndex = 0;
            this.button_Inter.Text = "Вход";
            this.button_Inter.UseVisualStyleBackColor = true;
            this.button_Inter.Click += new System.EventHandler(this.button_Inter_Click);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(12, 21);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 23);
            this.textBox_Login.TabIndex = 1;
            this.textBox_Login.Text = "Admin";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(12, 65);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(100, 23);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.Text = "Admin";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(40, 3);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(41, 15);
            this.label_Login.TabIndex = 3;
            this.label_Login.Text = "Логин";
            this.label_Login.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Location = new System.Drawing.Point(40, 47);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(49, 15);
            this.label_Pass.TabIndex = 4;
            this.label_Pass.Text = "Пароль";
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(123, 127);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.button_Inter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Auth";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Inter;
        private TextBox textBox_Login;
        private TextBox textBox_Password;
        private Label label_Login;
        private Label label_Pass;
    }
}
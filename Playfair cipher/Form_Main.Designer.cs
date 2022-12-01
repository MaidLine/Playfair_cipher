namespace Playfair_cipher
{
    partial class Form_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.textBox_Word = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.richTextBoxOut = new System.Windows.Forms.RichTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Descrypt = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.button_help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Слово";
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.Location = new System.Drawing.Point(12, 100);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(190, 23);
            this.button_Encrypt.TabIndex = 2;
            this.button_Encrypt.Text = "Зашифровать";
            this.button_Encrypt.UseVisualStyleBackColor = true;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // textBox_Word
            // 
            this.textBox_Word.Location = new System.Drawing.Point(12, 27);
            this.textBox_Word.Name = "textBox_Word";
            this.textBox_Word.Size = new System.Drawing.Size(190, 23);
            this.textBox_Word.TabIndex = 3;
            this.textBox_Word.Text = "Hello world";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(12, 71);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(190, 23);
            this.textBox_Key.TabIndex = 4;
            this.textBox_Key.Text = "Key";
            // 
            // richTextBoxOut
            // 
            this.richTextBoxOut.Location = new System.Drawing.Point(220, 27);
            this.richTextBoxOut.Name = "richTextBoxOut";
            this.richTextBoxOut.Size = new System.Drawing.Size(278, 67);
            this.richTextBoxOut.TabIndex = 5;
            this.richTextBoxOut.Text = "";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(220, 100);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(278, 23);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Descrypt
            // 
            this.button_Descrypt.Location = new System.Drawing.Point(12, 129);
            this.button_Descrypt.Name = "button_Descrypt";
            this.button_Descrypt.Size = new System.Drawing.Size(190, 23);
            this.button_Descrypt.TabIndex = 7;
            this.button_Descrypt.Text = "Расшифровать";
            this.button_Descrypt.UseVisualStyleBackColor = true;
            this.button_Descrypt.Click += new System.EventHandler(this.button_Descrypt_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(220, 129);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(278, 23);
            this.button_Load.TabIndex = 8;
            this.button_Load.Text = "Загрузить";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // button_help
            // 
            this.button_help.Location = new System.Drawing.Point(12, 158);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(486, 23);
            this.button_help.TabIndex = 9;
            this.button_help.Text = "Помощь";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // Form_main
            // 
            this.AcceptButton = this.button_Encrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 190);
            this.Controls.Add(this.button_help);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Descrypt);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.richTextBoxOut);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_Word);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.Text = "Шифр Плейфера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_FormClosed);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_Encrypt;
        private TextBox textBox_Word;
        private TextBox textBox_Key;
        private RichTextBox richTextBoxOut;
        private Button button_Save;
        private Button button_Descrypt;
        private Button button_Load;
        private Button button_help;
    }
}
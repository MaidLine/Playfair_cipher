namespace Playfair_cipher
{
    public partial class Form_Auth : Form
    {
        UserList newUser = new ();


        public Form_Auth()
        {
            InitializeComponent();
        }

        private void Form_Auth_Load(object sender, EventArgs e)
        {
            newUser.SingIn("Admin", "Admin");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Inter_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "" || textBox_Password.Text == "") MessageBox.Show("Убедитесь в том, что бы заполнили все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newUser.LogIn(textBox_Login.Text, textBox_Password.Text))
            {
                Form_main form_Main = new();
                form_Main.Show();
                this.Hide();
            }
            else MessageBox.Show("Данного пользователя не существует", "Ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button_Registration_Click(object sender, EventArgs e)
        {
            this.textBox_Login.Clear();
            this.textBox_Password.Clear();
            this.Text = "Регистрация";
            this.button_Inter.Visible = false;
            this.button_Registration.Visible = false;
            this.button_Complete_Reg.Visible = true;
            this.button_Cancel_Reg.Visible = true;
            this.label_Password_Repeated.Visible = true;
            this.textBox_Password_Repeated.Visible = true;
            Size = new Size(213, 235);
        }

        private void Button_Cancel_Reg_Click(object sender, EventArgs e)
        {
            this.Text = "Вход";
            this.button_Inter.Visible = true;
            this.button_Registration.Visible = true;
            this.button_Complete_Reg.Visible = false;
            this.button_Cancel_Reg.Visible = false;
            this.label_Password_Repeated.Visible = false;
            this.textBox_Password_Repeated.Visible = false;
            this.textBox_Login.Clear();
            this.textBox_Password.Clear();
            this.textBox_Password_Repeated.Clear();
            this.textBox_Password_Repeated.Clear();
            Size = new Size(213, 192);
        }

        private void Button_Complete_Reg_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "" || textBox_Password.Text == "" || textBox_Password_Repeated.Text == "") 
                MessageBox.Show("Убедитесь в том, что бы заполнили все поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (textBox_Password.Text == textBox_Password_Repeated.Text)
            {
                if (newUser.SingIn(textBox_Login.Text, textBox_Password.Text))
                {
                    MessageBox.Show("Вы зарегистрированы!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Text = "Вход";
                    this.button_Inter.Visible = true;
                    this.button_Registration.Visible = true;
                    this.button_Complete_Reg.Visible = false;
                    this.button_Cancel_Reg.Visible = false;
                    this.label_Password_Repeated.Visible = false;
                    this.textBox_Password_Repeated.Visible = false;
                    this.textBox_Login.Clear();
                    this.textBox_Password.Clear();
                    Size = new Size(213, 192);
                }
            }
            else MessageBox.Show("Убедитесь в правильности написания паролей!", "Пароли не совпадают ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

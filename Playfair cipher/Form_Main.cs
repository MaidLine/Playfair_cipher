using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Playfair_cipher
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            string word = textBox_Word.Text.ToUpper();
            string key = textBox_Key.Text.ToUpper();
            Encrypter encrypter = new Encrypter();
            encrypter.Encryption(word, key);
            richTextBoxOut.Text = encrypter.outtext;

        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBoxOut.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа создана для шифрровки-расшифроки текста, написанного на английском, шифром Плейфера." +
                "\nВажно!: длинна текста для шифрования < 32767;" +
                "\nдлинна ключа <= 26, включая .,!" +
                "\nДля расшифровки нужен ключ, которым шифровали текст!" +
                "\nИнструкция:" +
                "\n - введите текст для шифрования;" +
                "\n - введите ключ;" +
                "\n - нажмите на кнопку 'Зашифровать';" +
                "\n - готово! Можете сохранить в текстовый файл." +
                "\nТакже, можно загрузить текст из текстового файла и работать с ним.", "Гайд", MessageBoxButtons.OK);
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox_Word.Text = fileText;
        }

        private void button_Descrypt_Click(object sender, EventArgs e)
        {
            string encryptedword = textBox_Word.Text.ToUpper();
            string key = textBox_Key.Text.ToUpper();
            Encrypter encrypter = new Encrypter();
            encrypter.Descryption(encryptedword, key);
            richTextBoxOut.Text = encrypter.outtext;
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
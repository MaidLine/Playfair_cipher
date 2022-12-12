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

        private void Button_Encrypt_Click(object sender, EventArgs e)
        {
            string word = textBox_Word.Text;
            string key = textBox_Key.Text;
            Encrypter encrypter = new();
            encrypter.Encryption(word, key);
            richTextBoxOut.Text = encrypter.outtext;

        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // �������� ��������� ����
            string filename = saveFileDialog.FileName;
            // ��������� ����� � ����
            System.IO.File.WriteAllText(filename, richTextBoxOut.Text);
            MessageBox.Show("���� ��������");
        }

        private void Button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� ������� ��� ���������-���������� ������, ����������� �� ����������, ������ ��������." +
                "\n�����!: ������ ������ ��� ���������� < 32767;" +
                "\n������ ����� <= 26, ������� .,!" +
                "\n��� ����������� ����� ����, ������� ��������� �����!" +
                "\n����������:" +
                "\n - ������� ����� ��� ����������;" +
                "\n - ������� ����;" +
                "\n - ������� �� ������ '�����������';" +
                "\n - ������! ������ ��������� � ��������� ����." +
                "\n�����, ����� ��������� ����� �� ���������� ����� � �������� � ���.", "����", MessageBoxButtons.OK);
        }

        private void Button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // �������� ��������� ����
            string filename = openFileDialog.FileName;
            // ������ ���� � ������
            string fileText = System.IO.File.ReadAllText(filename);
            textBox_Word.Text = fileText;
        }

        private void Button_Descrypt_Click(object sender, EventArgs e)
        {
            string encryptedword = textBox_Word.Text;
            string key = textBox_Key.Text;
            Encrypter encrypter = new();
            encrypter.Descryption(encryptedword, key);
            richTextBoxOut.Text = encrypter.outtext;
        }

        private void Form_main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
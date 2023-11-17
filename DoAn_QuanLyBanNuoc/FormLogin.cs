using DoAn_QuanLyBanNuoc.Model;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormLogin : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();

        public FormLogin()
        {
            InitializeComponent();
        }

        string accountName = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxPass.Text = "Password";
            textBoxID.Text = "Username";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormChooseDrink fm = new FormChooseDrink();
            fm.Get = textBoxID.Text;
            ACCOUNT account = data.ACCOUNTs.FirstOrDefault(p => p.ACCOUNTID.CompareTo(textBoxID.Text) == 0 && p.PASSWORD.CompareTo(textBoxPass.Text) == 0);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
            }
            if (textBoxID.Text == ""|| textBoxPass.Text == "")
                MessageBox.Show("Please fill all the information!", "Notification!");
            else
            {
                if (account != null)
                {
                    var command = new SqlCommand();
                    command.Connection = conn;
                    command.CommandText = "SELECT FULLNAME FROM ACCOUNT WHERE ACCOUNTID ='" + textBoxID.Text + "';";
                    accountName = command.ExecuteScalar().ToString();
                    FormManager formQuanLy = new FormManager();
                    FormChooseDrink formchooseDrink = new FormChooseDrink();
                    if (checkBoxRemember.Checked == true)
                    {
                        formQuanLy.Message = accountName;
                        formQuanLy.Get = textBoxID.Text;
                        formchooseDrink.Message1 = textBoxID.Text;
                        this.Visible = false;
                        
                        formQuanLy.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        formQuanLy.Message = accountName;
                        formchooseDrink.Message1 = textBoxID.Text;
                        formQuanLy.Get = textBoxID.Text;
                        textBoxID.Clear();
                        textBoxPass.Clear();
                        this.Visible = false;
                        formQuanLy.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Incorrect username or password!", "Notification!");
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Text = "";
            this.textBoxPass.PasswordChar = '*';
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSignUp formRegister = new FormSignUp();
            formRegister.Show();
            formRegister.Dock = DockStyle.Fill;
        }

        private void changeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangeAccount formChange = new FormChangeAccount();
            formChange.Show();
            formChange.Dock = DockStyle.Fill;
        }

        private void deleteTheAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteAccount formDelete = new FormDeleteAccount();
            formDelete.Show();
            formDelete.Dock = DockStyle.Fill;
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormChooseDrink fm = new FormChooseDrink();
            fm.Get = textBoxID.Text;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '*')
                textBoxPass.PasswordChar = '\0';
            else
                textBoxPass.PasswordChar = '*';
        }
    }
}

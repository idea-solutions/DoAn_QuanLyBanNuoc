using DoAn_QuanLyBanNuoc.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormChangeAccount : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();

        public FormChangeAccount()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ACCOUNT account = data.ACCOUNTs.FirstOrDefault(p => p.ACCOUNTID.CompareTo(textBoxID.Text) == 0 && p.PASSWORD.CompareTo(textBoxoldpassword.Text) == 0);
            if (account != null)
            {
                if (textBoxFullName.Text == "" || textBoxID.Text == "" || textBoxPhoneNumber.Text == "" ||
                textBoxPass.Text == "" || textBoxConfirmPassword.Text == "")
                    MessageBox.Show("Please fill all the information!", "Notification!");
                else
                {
                    if (textBoxConfirmPassword.Text == textBoxPass.Text)
                    {
                        account.PASSWORD = textBoxPass.Text;
                        account.FULLNAME = textBoxFullName.Text;
                        account.PHONENUM = textBoxPhoneNumber.Text;
                        account.DATE = dateTimePicker.Value;
                        MessageBox.Show("Changed successful information!", "Notification!");
                        data.SaveChanges();
                    }
                    else
                        MessageBox.Show("Password does not match!", "Notification!");
                }
            }
            else
                MessageBox.Show("Can not change because incorrect username or password!", "Notification!");
        }

        private void FormChangeAccount_Load(object sender, EventArgs e)
        {
            textBoxFullName.Text = "Fullname";
            textBoxPhoneNumber.Text = "Phone Number";
            textBoxID.Text = "Username";
            textBoxPass.Text = "Create a password";
            textBoxConfirmPassword.Text = "Enter the password";
            textBoxoldpassword.Text = "Password";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxID_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
        }

        private void textBoxoldpassword_Click(object sender, EventArgs e)
        {
            textBoxoldpassword.Clear();
            textBoxoldpassword.PasswordChar = '*';
        }

        private void textBoxFullName_Click(object sender, EventArgs e)
        {
            textBoxFullName.Clear();
        }

        private void textBoxPhoneNumber_Click(object sender, EventArgs e)
        {
            textBoxPhoneNumber.Clear();
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Clear();
            this.textBoxPass.PasswordChar = '*';
        }

        private void textBoxConfirmPassword_Click(object sender, EventArgs e)
        {
            textBoxConfirmPassword.Clear();
            textBoxConfirmPassword.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxConfirmPassword.PasswordChar == '*')
                textBoxConfirmPassword.PasswordChar = '\0';
            else
                textBoxConfirmPassword.PasswordChar = '*';

            if (textBoxPass.PasswordChar == '*')
                textBoxPass.PasswordChar = '\0';
            else
                textBoxPass.PasswordChar = '*';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxoldpassword.PasswordChar == '*')
                textBoxoldpassword.PasswordChar = '\0';
            else
                textBoxoldpassword.PasswordChar = '*';
        }
    }
}

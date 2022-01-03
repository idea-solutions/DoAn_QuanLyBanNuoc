using DoAn_QuanLyBanNuoc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormSignUp : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text == "" || textBoxID.Text == "" || textBoxPhoneNumber.Text == "" ||
                textBoxPass.Text == "" || textBoxConfirmPassword.Text == "")
                MessageBox.Show("Please fill all the information!", "Notification!");
            else
            {
                if (textBoxConfirmPassword.Text == textBoxPass.Text)
                {
                    try
                    {
                        ACCOUNT account = new ACCOUNT();
                        account.ACCOUNTID = textBoxID.Text;
                        account.PASSWORD = textBoxPass.Text;
                        account.FULLNAME = textBoxFullName.Text;
                        account.PHONENUM = textBoxPhoneNumber.Text;
                        account.DATE = dateTimePicker.Value;
                        data.ACCOUNTs.Add(account);
                        data.SaveChanges();
                        MessageBox.Show("Added successful an account!", "Notification!");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Account already exists", "Notification!");
                    }
                }
                else
                    MessageBox.Show("Password does not match!", "Notification!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegisterAccount_Load(object sender, EventArgs e)
        {
            textBoxFullName.Text = "Fullname";
            textBoxPhoneNumber.Text = "Phone Number";
            textBoxID.Text = "Username";
            textBoxPass.Text = "Create a password";
            textBoxConfirmPassword.Text = "Enter the password";
        }

        private void textBoxFullName_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = "";
        }

        private void textBoxPhoneNumber_Click(object sender, EventArgs e)
        {
            textBoxPhoneNumber.Text = "";
        }

        private void textBoxID_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            this.textBoxPass.Text = "";
            this.textBoxPass.PasswordChar = '*';
        }

        private void textBoxConfirmPassword_Click(object sender, EventArgs e)
        {
            this.textBoxConfirmPassword.Text = "";
            this.textBoxConfirmPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPass.PasswordChar == '*')
                textBoxPass.PasswordChar = '\0';
            else
                textBoxPass.PasswordChar = '*';

            if (textBoxConfirmPassword.PasswordChar == '*')
                textBoxConfirmPassword.PasswordChar = '\0';
            else
                textBoxConfirmPassword.PasswordChar = '*';
        }
    }
}

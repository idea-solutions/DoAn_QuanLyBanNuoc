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
    public partial class FormDeleteAccount : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();
        public FormDeleteAccount()
        {
            InitializeComponent();
        }

        private void FormDeleteAccount_Load(object sender, EventArgs e)
        {
            textBoxID.Text = "Username";
            textBoxPass.Text = "Password";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ACCOUNT account = data.ACCOUNTs.FirstOrDefault(p => p.ACCOUNTID.CompareTo(textBoxID.Text) == 0 && p.PASSWORD.CompareTo(textBoxPass.Text) == 0);

            if (account != null)
            {
                if (textBoxID.Text == "" || textBoxPass.Text == "")
                    MessageBox.Show("Please fill all the information!", "Notification!");
                else
                {
                    DialogResult dlg = MessageBox.Show("Do you want to delete your account?", "Notification!", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        data.ACCOUNTs.Remove(account);
                        data.SaveChanges();
                        MessageBox.Show("Delete successful!", "Notification!");
                    }
                    else
                        MessageBox.Show("Password does not match!", "Notification!");
                }
            }
            else
                MessageBox.Show("Can not delete because username or password incorrect!", "Notification!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            textBoxPass.Clear();
            this.textBoxPass.PasswordChar = '*';
        }

        private void textBoxID_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
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

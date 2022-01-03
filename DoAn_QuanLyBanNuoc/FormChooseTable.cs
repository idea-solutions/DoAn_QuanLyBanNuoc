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
    public partial class FormChooseTable : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();
        public FormChooseTable()
        {
            InitializeComponent();
        }

        public void Check(string buttonName, Button btn)
        {
            BAN ban = data.BANs.FirstOrDefault(p => p.IDBAN.CompareTo(buttonName) == 0);
            if (ban != null)
            {
                if (ban.DACHON == true)
                    btn.BackColor = Color.Khaki;
                else if (ban.DACHON == false)
                    btn.BackColor = Color.White;
            }
        }

        public void CleanTable(string buttonName)
        {
            BAN ban = data.BANs.FirstOrDefault(p => p.IDBAN.CompareTo(buttonName) == 0);


            DialogResult dlg = MessageBox.Show("Do you want to clean this table?", "Notification!", MessageBoxButtons.YesNo);
            BAN table = data.BANs.FirstOrDefault(p => p.IDBAN.CompareTo(buttonName) == 0);
            if (dlg == DialogResult.Yes)
                if (table != null)
                {
                    table.DACHON = false;
                    data.SaveChanges();
                }
        }

        string strID;
        public string Get
        {
            get { return strID; }
            set { strID = value; }
        }

        private void FormChooseTable_Load(object sender, EventArgs e)
        {
            string namebutton1 = buttonB1.Text;
            string namebutton2 = buttonB2.Text;
            string namebutton3 = buttonB3.Text;
            string namebutton4 = buttonB4.Text;
            string namebutton5 = buttonB5.Text;
            string namebutton6 = buttonB6.Text;
            string namebutton7 = buttonB7.Text;
            string namebutton8 = buttonB8.Text;
            string namebutton9 = buttonB9.Text;
            Check(namebutton1, buttonB1);
            Check(namebutton2, buttonB2);
            Check(namebutton3, buttonB3);
            Check(namebutton4, buttonB4);
            Check(namebutton5, buttonB5);
            Check(namebutton6, buttonB6);
            Check(namebutton7, buttonB7);
            Check(namebutton8, buttonB8);
            Check(namebutton9, buttonB9);
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            string namebutton1 = buttonB1.Text;
            if (buttonB1.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB1.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton1);
                Check(namebutton1, buttonB1);
            }
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            string namebutton2 = buttonB2.Text;
            if (buttonB2.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB2.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton2);
                Check(namebutton2, buttonB2);
            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            string namebutton3 = buttonB3.Text;
            if (buttonB3.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB3.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton3);
                Check(namebutton3, buttonB3);
            }
        }

        private void buttonB4_Click(object sender, EventArgs e)
        {
            string namebutton4 = buttonB4.Text;
            if (buttonB4.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB4.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton4);
                Check(namebutton4, buttonB4);
            }
        }

        private void buttonB5_Click(object sender, EventArgs e)
        {
            string namebutton5 = buttonB5.Text;
            if (buttonB5.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB5.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton5);
                Check(namebutton5, buttonB5);
            }
        }

        private void buttonB6_Click(object sender, EventArgs e)
        {
            string namebutton6 = buttonB6.Text;
            if (buttonB6.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB6.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton6);
                Check(namebutton6, buttonB6);
            }
        }

        private void buttonB7_Click(object sender, EventArgs e)
        {
            string namebutton7 = buttonB7.Text;
            if (buttonB7.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB7.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton7);
                Check(namebutton7, buttonB7);
            }
        }

        private void buttonB8_Click(object sender, EventArgs e)
        {
            string namebutton8 = buttonB8.Text;
            if (buttonB8.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB8.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton8);
                Check(namebutton8, buttonB8);
            }
        }

        private void buttonB9_Click(object sender, EventArgs e)
        {
            string namebutton9 = buttonB9.Text;
            if (buttonB9.BackColor == Color.White)
            {
                FormChooseDrink formChonNuoc = new FormChooseDrink();
                formChonNuoc.Sender(buttonB9.Text);
                formChonNuoc.Get = strID;
                formChonNuoc.Show();
            }
            else
            {
                CleanTable(namebutton9);
                Check(namebutton9, buttonB9);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormChooseTable f = new FormChooseTable();
            f.Visible = true;
        }
    }
}

using DoAn_QuanLyBanNuoc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormManagerDrink : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();
        public FormManagerDrink()
        {
            InitializeComponent();
        }

        private void FormManagerDrink_Load(object sender, EventArgs e)
        {
            textBoxWaterID.Text = "DrinkID";
            textBoxwatername.Text = "Drink name";
            textBoxGia.Text = "Cost";
            LoadData();
            
        }

        public void LoadData()
        {
            List<NUOC> listNuoc = data.NUOCs.ToList();
            Setup();
            BindGrid(listNuoc);
        }

        public void Setup()
        {
            dataGridViewWater.Columns.Clear();
            List<string> cotNames = new List<string> { "STT", "WATERID", "WATERNAME", "Unit Price" };
            List<string> cotHeaders = new List<string> { "STT", "DRINK ID", "DRINK NAME", "COST" };
            dataGridViewWater.ColumnCount = cotNames.Count;

            for (int i = 0; i < cotNames.Count; i++)
            {
                dataGridViewWater.Columns[i].Name = cotNames[i];
                dataGridViewWater.Columns[i].HeaderText = cotHeaders[i];
                dataGridViewWater.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewWater.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewWater.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewWater.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void BindGrid(List<NUOC> listOrder)
        {
            dataGridViewWater.Rows.Clear();
            for (int i = 0; i < listOrder.Count; i++)
            {
                int index = dataGridViewWater.Rows.Add();
                dataGridViewWater.Rows[index].Cells[0].Value = dataGridViewWater.RowCount;
                dataGridViewWater.Rows[index].Cells[1].Value = listOrder[i].IDNUOC;
                dataGridViewWater.Rows[index].Cells[2].Value = listOrder[i].TENNUOC;
                dataGridViewWater.Rows[index].Cells[3].Value = listOrder[i].GIA;
            }
        }

        private void dataGridViewWater_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewWater.Rows[e.RowIndex];
                textBoxWaterID.Text = row.Cells[1].Value.ToString();
                textBoxwatername.Text = row.Cells[2].Value.ToString();
                textBoxGia.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            if (textBoxWaterID.Text == "" || textBoxwatername.Text == "" || textBoxGia.Text == "")
                MessageBox.Show("Please fill all the information!", "Notification!");
            else
            {
                NUOC s = new NUOC();
                s.IDNUOC = textBoxWaterID.Text;
                s.TENNUOC = textBoxwatername.Text;
                s.GIA = int.Parse(textBoxGia.Text);
                data.NUOCs.AddOrUpdate(s);
                data.SaveChanges();
                MessageBox.Show("Successful!", "Notification!");
                LoadData();
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            NUOC nuoc = data.NUOCs.FirstOrDefault(p => p.IDNUOC.CompareTo(textBoxWaterID.Text) == 0);

            if (nuoc != null)
            {
                if (textBoxWaterID.Text == "")
                    MessageBox.Show("Please enter the DrinkID!", "Notification!");
                else
                {
                    DialogResult dlg = MessageBox.Show("Do you want to delete drinks?", "Notification!", MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        data.NUOCs.Remove(nuoc);
                        data.SaveChanges();
                        MessageBox.Show("Delete successful!", "Notification!");
                        LoadData();
                    }
                }
            }
            else
                MessageBox.Show("Can not delete because DrinkID incorrect!", "Notification!");
        }

        private void textBoxWaterID_Click(object sender, EventArgs e)
        {
            textBoxWaterID.Clear();
        }

        private void textBoxwatername_Click(object sender, EventArgs e)
        {
            textBoxwatername.Clear();
        }

        private void textBoxGia_Click(object sender, EventArgs e)
        {
            textBoxGia.Clear();
        }
    }
}

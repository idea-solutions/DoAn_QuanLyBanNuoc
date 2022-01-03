using DoAn_QuanLyBanNuoc.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormManager : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();

        public FormManager()
        {
            InitializeComponent();
        }
        string strNhan;
        string strNhan1;
        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }

        public string Message1
        {
            get { return strNhan1; }
            set { strNhan1 = value; }
        }

        string strID;
        public string Get
        {
            get { return strID; }
            set { strID = value; }
        }

        private void FormManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            labelAccountName.Text = strNhan;
            List<ORDER_TABLE> listorder = data.ORDER_TABLE.ToList();
            Setup();
            BindGrid(listorder);
            Tong();
        }

        public void Tong()
        {
            long tong = 0;
            for (int i = 0; i < dataGridViewOrder.RowCount; i++)
            {
                tong += int.Parse(dataGridViewOrder.Rows[i].Cells[6].Value.ToString());
            }
            labelSum.Text = tong.ToString();
        }

        public void Setup()
        {
            dataGridViewOrder.Columns.Clear();
            List<string> cotNames = new List<string> { "STT", "IDBAN", "IDORDER", "STAFF", "NAME OF DRINKS", "SUM", "Total", "DATE" };
            List<string> cotHeaders = new List<string> { "STT", "IDTABLE", "TIMES ORDER", "STAFF", "NAME OF DRINKS", "QUANTITY", "TOTAL MONEY", "DATE" };
            
            dataGridViewOrder.ColumnCount = cotNames.Count;

            for (int i = 0; i < cotNames.Count; i++)
            {
                dataGridViewOrder.Columns[i].Name = cotNames[i];
                dataGridViewOrder.Columns[i].HeaderText = cotHeaders[i];
                
            }
            dataGridViewOrder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrder.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrder.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
        }

        private void BindGrid(List<ORDER_TABLE> listOrder)
        {
            dataGridViewOrder.Rows.Clear();
            for (int i = 0; i < listOrder.Count; i++)
            {
                int index = dataGridViewOrder.Rows.Add();
                dataGridViewOrder.Rows[index].Cells[0].Value = dataGridViewOrder.RowCount;
                dataGridViewOrder.Rows[index].Cells[1].Value = listOrder[i].IDBAN;
                dataGridViewOrder.Rows[index].Cells[2].Value = listOrder[i].IDORDER;
                dataGridViewOrder.Rows[index].Cells[3].Value = listOrder[i].ACCOUNT.FULLNAME;
                dataGridViewOrder.Rows[index].Cells[4].Value = listOrder[i].NUOC.TENNUOC;
                dataGridViewOrder.Rows[index].Cells[5].Value = listOrder[i].SOLUONGNUOC;
                dataGridViewOrder.Rows[index].Cells[6].Value = listOrder[i].TONGTIEN;
                dataGridViewOrder.Rows[index].Cells[7].Value = listOrder[i].THOIGIAN;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do you want to logout?", "Notification!", MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
                this.Close();
        }

        public void ShowAll()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY ORDER_TABLE.IDBAN) AS [STT], ORDER_TABLE.IDBAN AS [IDTABLE] ,ORDER_TABLE.IDORDER AS [TIMES ORDER] , ACCOUNT.FULLNAME AS [STAFF]," +
                "NUOC.TENNUOC AS [NAME OF DRINKS], ORDER_TABLE.SOLUONGNUOC AS [QUANTITY], ORDER_TABLE.TONGTIEN AS [TOTAL MONEY], ORDER_TABLE.THOIGIAN AS [DATE] FROM ORDER_TABLE, ACCOUNT, " +
                "NUOC WHERE ORDER_TABLE.IDNUOC = NUOC.IDNUOC AND ACCOUNT.ACCOUNTID = ORDER_TABLE.ACCOUNTID ", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewOrder.Columns.Clear();
            dataGridViewOrder.DataSource = ds.Tables[0];
            for (int i = 0; i < dataGridViewOrder.Columns.Count; i++)
            {
                dataGridViewOrder.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
               dataGridViewOrder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               dataGridViewOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               dataGridViewOrder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               dataGridViewOrder.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               dataGridViewOrder.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               dataGridViewOrder.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               dataGridViewOrder.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
               dataGridViewOrder.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tong();
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormChooseTable formChooseTable = new FormChooseTable();
            formChooseTable.Get = strID;
            formChooseTable.Show();
        }

        public void TimKiem()
        {
            string deliverydate1 = dateTimePicker1.Value.ToString();
            string deliverydate2 = dateTimePicker2.Value.ToString();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY ORDER_TABLE.IDBAN) AS [STT], ORDER_TABLE.IDBAN AS [IDTABLE] ,ORDER_TABLE.IDORDER AS [TIMES ORDER] ,ACCOUNT.FULLNAME AS[STAFF], " +
                "NUOC.TENNUOC AS [NAME OF DRINKS], ORDER_TABLE.SOLUONGNUOC AS [QUANTITY], ORDER_TABLE.TONGTIEN AS [TOTAL MONEY], ORDER_TABLE.THOIGIAN AS [DATE] FROM ORDER_TABLE, ACCOUNT, " +
                "NUOC WHERE ORDER_TABLE.IDNUOC = NUOC.IDNUOC AND ACCOUNT.ACCOUNTID = ORDER_TABLE.ACCOUNTID AND " +
                "ORDER_TABLE.THOIGIAN BETWEEN '" + deliverydate1 + "' AND '" + deliverydate2 + "'", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewOrder.Columns.Clear();
            dataGridViewOrder.DataSource = ds.Tables[0];
            for (int i = 0; i < dataGridViewOrder.Columns.Count; i++)
            {
                dataGridViewOrder.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewOrder.Columns[7].DefaultCellStyle.Format = "d/MM/yyyy hh:mm:ss tt";
            }
            dataGridViewOrder.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewOrder.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewOrder.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tong();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void buttondeletehistory_Click(object sender, EventArgs e)
        {
            int order = int.Parse(textBoxOrder.Text);

            if (textBoxBan.Text == "" || textBoxOrder.Text == "")
                MessageBox.Show("Please choose a table", "Notification!");
            else
            {
                ORDER_TABLE table = data.ORDER_TABLE.FirstOrDefault(p => p.IDORDER.CompareTo(order) == 0 && p.IDBAN.CompareTo(textBoxBan.Text) == 0);

                if (table != null)
                {
                    DialogResult dlg = MessageBox.Show("Do you want to delete order", "Notification!",
                                MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                    {
                        data.ORDER_TABLE.Remove(table);
                        data.SaveChanges();
                        MessageBox.Show("Remove successful order!", "Notification!");
                        LoadData();
                    }
                }
            }
        }

        private void dataGridViewOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewOrder.Rows[e.RowIndex];
                textBoxBan.Text = row.Cells[1].Value.ToString();
                textBoxOrder.Text = row.Cells[2].Value.ToString();
            }
        }

        private void waterManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagerDrink formManagerDrink = new FormManagerDrink();
            formManagerDrink.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReport form = new FormReport();
            form.Get = labelAccountName.Text;
            form.Show();
        }
    }
}

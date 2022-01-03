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
    public partial class FormChooseDrink : Form
    {
        public SendMessage Sender; public FormChooseDrink()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

        string strNhan1;
        string strID;
        public string Get
        {
            get { return strID; }
            set { strID = value; }
        }
        public string Message1
        {
            get { return strNhan1; }
            set { strNhan1 = value; }
        }

        QLNuocDBContext data = new QLNuocDBContext();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.ConnectionString);
        int idorder = 0;
        long oldMoney = 0;
        string timesOrder = "";
        public delegate void SendMessage(string Message);

        private void GetMessage(string Message)
        {
            textBoxBan.Text = Message;
        }
        
        private void FormChooseDrink_Load(object sender, EventArgs e)
        {
            
            labeladd();
            LoadData();
            timesOrder = textBoxOrder.Text;
            comboBoxNuoc.Text = "Choose a drink";
            textBoxSoLuong.Text = "Enter the quantity";
        }

        public void labeladd()
        {
            conn.Open();
            var command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "select MAX(IDORDER)+1 as [Next booking] from ORDER_TABLE where IDBAN = '"+ textBoxBan.Text +"'";
            textBoxOrder.Text = command.ExecuteScalar().ToString();
            if (textBoxOrder.Text == "")
            {
                textBoxOrder.Text = "1";
            }
        }

        public void LoadData()
        {
            labelMoney.Text = "0";
            List<NUOC> listNuoc = data.NUOCs.ToList();
            List<ORDER_TABLE> listorder = data.ORDER_TABLE.ToList();
            FillComboboxNuoc(listNuoc);
            Setup();
            BindGrid(listorder);
            dataGridViewChonNuoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewChonNuoc.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewChonNuoc.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
        }

        public void Setup()
        {
            dataGridViewChonNuoc.Columns.Clear();
            List<string> cotNames = new List<string> { "STT", "IDBAN", "IDORDER", "STAFF", "NAME OF DRINKS", "SUM", "Total", "DATE" };
            List<string> cotHeaders = new List<string> { "STT", "IDTABLE", "TIMES ORDER", "STAFF", "NAME OF DRINKS", "QUANTITY", "TOTAL MONEY", "DATE" };
            
            dataGridViewChonNuoc.ColumnCount = cotNames.Count;

            for (int i = 0; i < cotNames.Count; i++)
            {
                dataGridViewChonNuoc.Columns[i].Name = cotNames[i];
                dataGridViewChonNuoc.Columns[i].HeaderText = cotHeaders[i];
            }
            
            labelGia.Text = "";


        }
        private void BindGrid(List<ORDER_TABLE> list)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ROW_NUMBER() OVER (ORDER BY ORDER_TABLE.IDBAN) AS [STT]," +
                " ORDER_TABLE.IDBAN AS [IDTABLE] ,ORDER_TABLE.IDORDER AS [TIMES ORDER] ,ACCOUNT.FULLNAME AS[STAFF], NUOC.TENNUOC AS [NAME OF DRINKS]," +
                " ORDER_TABLE.SOLUONGNUOC AS [QUANTITY], ORDER_TABLE.TONGTIEN AS [TOTAL MONEY], ORDER_TABLE.THOIGIAN AS [DATE]" +
                " FROM ORDER_TABLE, NUOC, ACCOUNT WHERE ORDER_TABLE.IDNUOC = NUOC.IDNUOC AND ACCOUNT.ACCOUNTID = ORDER_TABLE.ACCOUNTID AND ORDER_TABLE.IDBAN = '" + textBoxBan.Text + "'", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewChonNuoc.Columns.Clear();
            dataGridViewChonNuoc.DataSource = ds.Tables[0];
            for (int i = 0; i < dataGridViewChonNuoc.Columns.Count; i++)
            {
                dataGridViewChonNuoc.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void comboBoxNuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NUOC> listNuoc = data.NUOCs.ToList();
            var a = listNuoc.Where(p => p.TENNUOC == comboBoxNuoc.Text);
            foreach (NUOC pl in a)
            {
                labelGia.Text = pl.GIA.ToString();
            }
        }

        private void FillComboboxNuoc(List<NUOC> listNuoc)
        {
            this.comboBoxNuoc.DataSource = listNuoc;
            this.comboBoxNuoc.DisplayMember = "TenNuoc";
            this.comboBoxNuoc.ValueMember = "IDNuoc";
            this.comboBoxNuoc.SelectedIndex = -1;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            
            List<ORDER_TABLE> listOrder = data.ORDER_TABLE.ToList();

            if (comboBoxNuoc.SelectedIndex == -1 || textBoxSoLuong.Text == "")
                MessageBox.Show("Please fill all the information!");
            else
            {

                    long tong = long.Parse(textBoxSoLuong.Text) * long.Parse(labelGia.Text);
                    BAN table = data.BANs.FirstOrDefault(p => p.IDBAN.CompareTo(textBoxBan.Text) == 0);
                    if (table != null)
                    {
                        table.DACHON = true;
                        data.SaveChanges();
                    }
                    ORDER_TABLE order = new ORDER_TABLE();
                    order.IDBAN = textBoxBan.Text;
                    order.ACCOUNTID = strID;
                    order.IDORDER = int.Parse(textBoxOrder.Text);
                    order.IDNUOC = comboBoxNuoc.SelectedValue.ToString();
                    order.SOLUONGNUOC = int.Parse(textBoxSoLuong.Text);
                    order.TONGTIEN = tong;
                    order.THOIGIAN = DateTime.Now;
                    data.ORDER_TABLE.Add(order);
                    data.SaveChanges();
                    MessageBox.Show("Added successful an order!", "Notification!");
                    int orderupdate = int.Parse(textBoxOrder.Text) + 1;
                    textBoxOrder.Text = orderupdate.ToString();
                    dataGridViewChonNuoc.Columns.Clear();
                    BindGrid(listOrder);
                    long money = long.Parse(labelMoney.Text);
                    money += tong;
                    labelMoney.Text = money.ToString();

            }
            dataGridViewChonNuoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewChonNuoc.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewChonNuoc.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewChonNuoc.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            List<ORDER_TABLE> listOrder = data.ORDER_TABLE.ToList();
            if (comboBoxNuoc.SelectedIndex == -1 || textBoxSoLuong.Text == "")
                MessageBox.Show("Please fill all the information!", "Notification!");
            else
            {
                ORDER_TABLE order = data.ORDER_TABLE.FirstOrDefault(p => p.IDBAN.CompareTo(textBoxBan.Text) == 0 && p.IDORDER.CompareTo(idorder) == 0);
                if (order != null)
                {
                    long tong = long.Parse(textBoxSoLuong.Text) * long.Parse(labelGia.Text);
                    order.IDNUOC = comboBoxNuoc.SelectedValue.ToString();
                    order.ACCOUNTID = strID;
                    order.SOLUONGNUOC = int.Parse(textBoxSoLuong.Text);
                    order.TONGTIEN = tong;
                    order.THOIGIAN = DateTime.Now;
                    data.SaveChanges();
                    MessageBox.Show("Edited successful  an order!", "Notification!");
                    int orderupdate = int.Parse(textBoxOrder.Text) + 1;
                    textBoxOrder.Text = orderupdate.ToString();
                    dataGridViewChonNuoc.Columns.Clear();
                    BindGrid(listOrder);
                    long money = long.Parse(labelMoney.Text);
                    money -= oldMoney;
                    money += tong;
                    labelMoney.Text = money.ToString();
                }
                else
                    MessageBox.Show("Not found!");

                dataGridViewChonNuoc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewChonNuoc.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewChonNuoc.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewChonNuoc.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewChonNuoc.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewChonNuoc.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridViewChonNuoc.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewChonNuoc.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss tt";
            }
        }

        private void dataGridViewChonNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewChonNuoc.Rows[e.RowIndex];
                textBoxSoLuong.Text = row.Cells[5].Value.ToString();
                comboBoxNuoc.Text = row.Cells[4].Value.ToString();
                oldMoney = long.Parse(row.Cells[6].Value.ToString());
                idorder = int.Parse(row.Cells[2].Value.ToString());
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBill form = new FormBill();
            form.Message = textBoxBan.Text;
            form.Message1 = timesOrder;
            form.Show();
        }

        private void textBoxSoLuong_Click(object sender, EventArgs e)
        {
            textBoxSoLuong.Clear();
        }
    }
}

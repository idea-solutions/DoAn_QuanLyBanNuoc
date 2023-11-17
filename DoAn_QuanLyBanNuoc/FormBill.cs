using DoAn_QuanLyBanNuoc.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormBill : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();

        public SendMessage Sender; 
        
        public FormBill()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

        public delegate void SendMessage(string Message);

        //string idban = "";
        //int idorder = 0;
        string strNhan;
        string strNhan1;
        public string Message
        {
            get { return strNhan; }  set { strNhan = value; }
        }

        public string Message1
        {
            get { return strNhan1; }
            set { strNhan1 = value; }
        }

        private void GetMessage(string Message)
        {
            textBoxBan.Text = Message;
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            textBoxBan.Text = strNhan;
            textBoxOrder.Text = strNhan1;
            int timeOrder = int.Parse(strNhan1);
            List<ORDER_TABLE> listOrder = data.ORDER_TABLE.Where(p=> p.IDBAN == strNhan && p.IDORDER >= timeOrder).OrderByDescending(p => p.THOIGIAN).ToList();
            List<QuanLyBanNuocReport> listReport = new List<QuanLyBanNuocReport>();
            foreach (ORDER_TABLE i in listOrder)
            {
                QuanLyBanNuocReport temp = new QuanLyBanNuocReport();
                temp.IDTABLE = i.IDBAN;
                temp.TIMESORDER = i.IDORDER;
                temp.FULLNAME = i.ACCOUNT.FULLNAME;
                temp.DRINKNAME = i.NUOC.TENNUOC;
                temp.QUANTITY = i.SOLUONGNUOC;
                temp.TOTALMONEY = i.TONGTIEN;
                temp.DATE = i.THOIGIAN;

                listReport.Add(temp);
            }

            this.reportViewer1.LocalReport.ReportPath = @"C:\_\DoAn_QuanLyBanNuoc\DoAn_QuanLyBanNuoc\Report2.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}

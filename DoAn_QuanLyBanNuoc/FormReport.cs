using DoAn_QuanLyBanNuoc.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAn_QuanLyBanNuoc
{
    public partial class FormReport : Form
    {
        QLNuocDBContext data = new QLNuocDBContext();
        public FormReport()
        {
            InitializeComponent();
        }

        string staff;
        public string Get
        {
            get { return staff; }
            set { staff = value; }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;
            List<ORDER_TABLE> listOrder = data.ORDER_TABLE.Where(p => p.THOIGIAN >= a && p.THOIGIAN <= b).OrderBy(p => p.IDBAN).ToList();
            List<QuanLyBanNuocReport> listReport = new List<QuanLyBanNuocReport>();
            foreach (ORDER_TABLE i in listOrder)
            {
                QuanLyBanNuocReport temp = new QuanLyBanNuocReport();
                temp.IDTABLE = i.IDBAN;
                temp.FULLNAME = i.ACCOUNT.FULLNAME;
                temp.TIMESORDER = i.IDORDER;
                temp.DRINKNAME = i.NUOC.TENNUOC;
                temp.QUANTITY = i.SOLUONGNUOC;
                temp.TOTALMONEY = i.TONGTIEN;
                temp.DATE = i.THOIGIAN;
                temp.STAFF = staff;
                listReport.Add(temp);
            }

            this.reportViewer1.LocalReport.ReportPath = @"C:\_\DoAn_QuanLyBanNuoc\DoAn_QuanLyBanNuoc\Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime a = dateTimePicker1.Value;
            DateTime b = dateTimePicker2.Value;
            List<ORDER_TABLE> listOrder = data.ORDER_TABLE.Where(p => p.THOIGIAN >= a && p.THOIGIAN <= b).OrderByDescending(p => p.THOIGIAN).ToList();
            List<QuanLyBanNuocReport> listReport = new List<QuanLyBanNuocReport>();
            foreach (ORDER_TABLE i in listOrder)
            {
                QuanLyBanNuocReport temp = new QuanLyBanNuocReport();
                temp.IDTABLE = i.IDBAN;
                temp.FULLNAME = i.ACCOUNT.FULLNAME;
                temp.TIMESORDER = i.IDORDER;
                temp.DRINKNAME = i.NUOC.TENNUOC;
                temp.QUANTITY = i.SOLUONGNUOC;
                temp.TOTALMONEY = i.TONGTIEN;
                temp.DATE = i.THOIGIAN;
                temp.STAFF = staff;
                listReport.Add(temp);
            }

            this.reportViewer1.LocalReport.ReportPath = @"C:\_\DoAn_QuanLyBanNuoc\DoAn_QuanLyBanNuoc\Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listReport);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}

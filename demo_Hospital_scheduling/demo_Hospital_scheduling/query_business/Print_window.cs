using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.Pdf;
using FastReport.Data;
using FastReport.Format;

namespace demo_Hospital_scheduling.query_business   
{
    public partial class Print_window : Form        //表报打印窗口
    {
        public DataGridView d1;
        public ComboBox b1;
        public Print_window(DataGridView datagridview,ComboBox combobox)
        {
            InitializeComponent();
            d1 = datagridview;
            b1 = combobox;
        }

        private void Print_window_Load(object sender, EventArgs e)
        {
            string dialog = @"..\..\paibanbiao.frx";
            Report report = new Report();//新建报表
            report.Load(dialog);

            report.SetParameterValue("Office",b1.SelectedValue);                        //报表填充时间
            report.SetParameterValue("days.Monday",d1.Rows[0].Cells[1].Value);
            report.SetParameterValue("days.Tuesday", d1.Rows[0].Cells[2].Value);
            report.SetParameterValue("days.Wednesday", d1.Rows[0].Cells[3].Value);
            report.SetParameterValue("days.Thursday", d1.Rows[0].Cells[4].Value);
            report.SetParameterValue("days.Friday", d1.Rows[0].Cells[5].Value);
            report.SetParameterValue("days.Saturday", d1.Rows[0].Cells[6].Value);
            report.SetParameterValue("days.Sunday", d1.Rows[0].Cells[7].Value);

            for (int i = 1; i < 8; i++)                                                 //将早班医生姓名填充进报表
            {
                string names = "";
                try
                {
                    for (int j = 1; j < 10; j++)
                    {
                        if (d1.Rows[j].Cells[i].Value != null)
                        {
                            names += d1.Rows[j].Cells[i].Value.ToString() + " ";
                        }
                    }
                    report.SetParameterValue("zaoban.zaoban" + i.ToString(), names);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }

           


            for (int i = 1; i < 8; i++)//将晚班医生姓名填充进报表
            {
                string names = "";
                
                try
                {
                    for (int j = 10; j < 19; j++)
                    {
                        if (d1.Rows[j].Cells[i].Value != null)
                        {
                            names += d1.Rows[j].Cells[i].Value.ToString() + " ";
                        }
                    }
                    report.SetParameterValue("wanban.wanban" + i.ToString(), names);
                }
                catch { }
            }

            report.Preview = this.previewControl1;//显示报表
            report.Show();
            

        }
    }
}

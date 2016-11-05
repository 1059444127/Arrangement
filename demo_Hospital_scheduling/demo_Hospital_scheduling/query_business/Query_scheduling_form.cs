using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enity;
using FastReport;
using FastReport.Data;

using demo_Hospital_scheduling.BLL;

namespace demo_Hospital_scheduling.query_business
{
    public partial class Query_scheduling_form : Form
    {
        datagridviewHelper dg = new datagridviewHelper();
        string user_name = app.user_name;

        public Query_scheduling_form()
        {
            InitializeComponent();
        }

        private void Query_scheduling_form_Load(object sender, EventArgs e)
        {
            showTime.showAPM(dataGridView1);

            Bdoctorinfo Bd = new Bdoctorinfo();             //显示科室选项
            comboBox1.DisplayMember = "Office";
            comboBox1.ValueMember = "Office";
            this.comboBox1.DataSource = Bd.QuaryOffice().Tables[0];

            comboBox3.DisplayMember = "name";               //显示可选调班医生
            comboBox3.ValueMember = "name";
            this.comboBox3.DataSource = Bd.QuaryDoctorNameByOffice(app.user_office).Tables[0];

            showTime.show(dataGridView1, dateTimePicker1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showTime.show(dataGridView1, dateTimePicker1);

            datagridviewHelper dg = new datagridviewHelper();
            dg.Search(dataGridView1, comboBox1);     //查找排班信息

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { dg.tiaoban_application(user_name, dateTimePicker2, dateTimePicker4, comboBox3, textBox1); }
            catch { }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { dg.qingjia_application(user_name, dateTimePicker3, textBox2); }
            catch { }      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Print_window pw = new Print_window(dataGridView1,comboBox1);
            pw.Show();
        }
    }
}

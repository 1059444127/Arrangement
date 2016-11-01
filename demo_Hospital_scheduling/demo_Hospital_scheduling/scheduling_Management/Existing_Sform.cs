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
using demo_Hospital_scheduling.BLL;

namespace demo_Hospital_scheduling.scheduling_Management
{
    public partial class Existing_Sform : Form
    {
        public Existing_Sform()
        {
            InitializeComponent();
        
        }

        private void Existing_Sform_Load(object sender, EventArgs e)
        {

            showTime.showAPM(dataGridView1);


            Bdoctorinfo Bd = new Bdoctorinfo();         //显示科室选项
            comboBox1.DisplayMember = "Office";
            comboBox1.ValueMember = "Office";
            this.comboBox1.DataSource = Bd.QuaryOffice().Tables[0];

            showTime.show(dataGridView1, dateTimePicker1);

        }

        private void button1_Click(object sender, EventArgs e)  //根据所选日期调整排班表第一行日期
        {
            showTime.show(dataGridView1, dateTimePicker1);

            datagridviewHelper dg = new datagridviewHelper();   
            dg.Search(dataGridView1,comboBox1);     //查找排班信息
           
        }
    }

}

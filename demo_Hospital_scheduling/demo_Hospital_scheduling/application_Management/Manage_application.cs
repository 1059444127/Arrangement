using demo_Hospital_scheduling.BLL;
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

namespace demo_Hospital_scheduling.application_Management
{
    public partial class Manage_application : Form
    {
        datagridviewHelper dg = new datagridviewHelper();
        string[] qingjia_Id = new string[20] ; //用于存放显示的申请记录ID
        string[] tiaoban_Id = new string[20] ;

        public Manage_application()
        {
            InitializeComponent();
        }

        private void Manage_application_Load(object sender, EventArgs e)
        {
            Bchangerecord bc = new Bchangerecord();
            comboBox1.DisplayMember = "Office";
            comboBox1.ValueMember = "Office";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z = 1;//用于区分请假和调班
            try {qingjia_Id= dg.ShowChangeRecord(dataGridView1, comboBox1,z); }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int z = 0;//用于区分请假和调班
            try { tiaoban_Id = dg.ShowChangeRecord(dataGridView2, comboBox2, z); }
            catch { }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z=1;
            try { dg.Execution(checkBox4, checkBox3, dataGridView1, textBox1, qingjia_Id, z); }
            catch { }
          
            
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                checkBox3.Enabled = false;
            else
                checkBox3.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                checkBox4.Enabled = false;
            else
                checkBox4.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox1.Enabled = false;
            else
                checkBox1.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox2.Enabled = false;
            else
                checkBox2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int z = 0;
            try { dg.Execution(checkBox2, checkBox1, dataGridView2, textBox2, tiaoban_Id, z); }
            catch { }
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Enity;

using demo_Hospital_scheduling.BLL;
using DAL;

namespace demo_Hospital_scheduling.scheduling_Management
{
    public partial class New_Sform : Form
    {
        string currentoffice;
    
        public static Bdoctorinfo Bd = new Bdoctorinfo();
        public New_Sform()
        {
            InitializeComponent();
        }

        private void New_Sform_Load(object sender, EventArgs e)
        {
            showTime.showAPM(dataGridView1);

            //显示科室选项
            comboBox1.DisplayMember = "office";
            comboBox1.ValueMember = "office";
            this.comboBox1.DataSource = Bd.QuaryOffice().Tables[0];

            showTime.show(dataGridView1, dateTimePicker1);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            showTime.show(dataGridView1, dateTimePicker1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
            this.comboBox2.DataSource = Bd.QuaryDoctorNameByOffice(comboBox1.SelectedValue.ToString()).Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = comboBox2.SelectedValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Row = 1, Cell = 1;
            BUser arg = new BUser();
        
            DAO4Arrangement darrang = new DAO4Arrangement();
            for (Row = 1; Row <= 18; Row++)
                for (Cell = 1; Cell <= 7; Cell++)
                {
                    if (dataGridView1.Rows[Row].Cells[Cell].Value != null)
                    {
                        
                            DTO4Arrangement getarg = arg.getarrangment(Row, Cell, dataGridView1, dateTimePicker1, comboBox1);
                            darrang.insertArrangement(getarg.BeginTime, getarg.FinishTime, getarg.DoctorId, getarg.Office, getarg.DoctorName, getarg.DoctorJobTitle);
                            
                        
                        
                    }
                }
        }
    }
}

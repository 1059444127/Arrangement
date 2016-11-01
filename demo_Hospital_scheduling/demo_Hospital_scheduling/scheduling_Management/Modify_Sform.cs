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
    public partial class Modify_Sform : Form
    {

        string currentoffice;
        datagridviewHelper dg = new datagridviewHelper();   //实例化排班表显示帮助实例

        public static Bdoctorinfo Bd = new Bdoctorinfo();
        public Modify_Sform()
        {
            InitializeComponent();
        }

        private void Modify_Sform_Load(object sender, EventArgs e)
        {
            showTime.showAPM(dataGridView1);
           
            //显示科室选项
            comboBox1.DisplayMember = "Office";
            comboBox1.ValueMember = "Office";
            this.comboBox1.DataSource = Bd.QuaryOffice().Tables[0];

            showTime.show(dataGridView1, dateTimePicker1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            showTime.show(dataGridView1, dateTimePicker1);
            dg.Search(dataGridView1, comboBox1);     //查找排班信息
            currentoffice= comboBox1.SelectedValue.ToString(); //当前排班表的科室

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";
            this.comboBox2.DataSource = Bd.QuaryDoctorNameByOffice(comboBox1.SelectedValue.ToString()).Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() == currentoffice || currentoffice == null)   //防止错乱修改排班表
            {
                
                if (dataGridView1.CurrentCell.Value==null||dataGridView1.CurrentCell.Value.ToString()=="")    //新增医生则使用insertarrangement
                {             
                    dg.InsertArrangement(dataGridView1,comboBox1,comboBox2);
                }
                else        //更换医生则使用updatearrangement
                {
                    dg.UpdateArrangement(dataGridView1, comboBox1, comboBox2);
                }
                
            }
            else
            { MessageBox.Show("该医生不属于此科室！"); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dg.DelectArrangement(dataGridView1);    //删除选中排班记录用DelectArrangement
        }
    }
}

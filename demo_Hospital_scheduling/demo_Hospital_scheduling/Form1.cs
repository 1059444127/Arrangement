using demo_Hospital_scheduling.scheduling_Management;
using demo_Hospital_scheduling.application_Management;
using demo_Hospital_scheduling.query_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_Hospital_scheduling
{
    public partial class Form1 : Form
    {
      

        private RibbonButton rbTemp;
        public static Form1 frmMain;
        private string currentMiddleForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_name.Text = app.user_name;
            label_id.Text = app.user_id;
            label_office.Text = app.user_office;
            label_jobtitle.Text = app.user_jobtitle;

            label5.Text = label_office.Text;
            label8.Text = label_name.Text;
            label11.Text = DateTime.Now.ToString();


            HostPanel.ShowForm(this.panel3,"scheduling_Management","Existing_Sform");
            if (app.a == 0)
            {
                scheduling_Interface.Visible = false;
                rbTemp = ribbonButton1;
                ribbonButton1.Checked = true;
                HostPanel.ShowForm(this.panel3, "query_business", "Query_scheduling_form");
            }
            else
            {
                ribbonTab1.Visible = false;
                rbTemp = existing_Sform; //病人信息Ribbonbutton为当前选中
                existing_Sform.Checked = true;

            }
            
        }

        private void existing_Sform_Click_1(object sender, EventArgs e)
        {
            rbTemp.Checked = false;
            RibbonButton tsBtn = (RibbonButton)sender;
            tsBtn.Checked = true;                 //修改当前选定的button的Checked属性
            rbTemp = tsBtn;  //当前选定的button      
            currentMiddleForm = tsBtn.Tag.ToString();  //ribbon的tag属性事先设成窗体名，获取要显示的窗体的name
            HostPanel.ShowForm(this.panel3,"scheduling_Management","Existing_Sform");
        }

        private void new_Sform_Click(object sender, EventArgs e)
        {
            rbTemp.Checked = false;
            RibbonButton tsBtn = (RibbonButton)sender;
            tsBtn.Checked = true;                 //修改当前选定的button的Checked属性
            rbTemp = tsBtn;  //当前选定的button      
            currentMiddleForm = tsBtn.Tag.ToString();  //ribbon的tag属性事先设成窗体名，获取要显示的窗体的name
            HostPanel.ShowForm(this.panel3, "scheduling_Management", "New_Sform");       
        }

        private void modify_Sform_Click(object sender, EventArgs e)
        {
            rbTemp.Checked = false;
            RibbonButton tsBtn = (RibbonButton)sender;
            tsBtn.Checked = true;                 //修改当前选定的button的Checked属性
            rbTemp = tsBtn;  //当前选定的button      
            currentMiddleForm = tsBtn.Tag.ToString();  //ribbon的tag属性事先设成窗体名，获取要显示的窗体的name
            HostPanel.ShowForm(this.panel3, "scheduling_Management", "Modify_Sform");
        }

        private void manage_application_Click(object sender, EventArgs e)
        {
            rbTemp.Checked = false;
            RibbonButton tsBtn = (RibbonButton)sender;
            tsBtn.Checked = true;                 //修改当前选定的button的Checked属性
            rbTemp = tsBtn;  //当前选定的button      
            currentMiddleForm = tsBtn.Tag.ToString();  //ribbon的tag属性事先设成窗体名，获取要显示的窗体的name
            HostPanel.ShowForm(this.panel3, "application_Management", "Manage_application");
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            rbTemp.Checked = false;
            RibbonButton tsBtn = (RibbonButton)sender;
            tsBtn.Checked = true;                 //修改当前选定的button的Checked属性
            rbTemp = tsBtn;  //当前选定的button      
            currentMiddleForm = tsBtn.Tag.ToString();  //ribbon的tag属性事先设成窗体名，获取要显示的窗体的name
            HostPanel.ShowForm(this.panel3, "query_business", "Query_scheduling_form");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

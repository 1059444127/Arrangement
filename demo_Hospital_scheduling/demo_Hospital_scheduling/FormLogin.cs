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
using BLL;

namespace demo_Hospital_scheduling
{
    
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string id = TextUserid.Text.Trim();
                string password = TextPassName.Text.Trim();
                BUser mgr = new BUser();
                DTO4ManagerInfo manager = mgr.ManagerLogin(id, password);
           
                if (id == null || id == "")                                     //输入名和密码不能为空
                    MessageBox.Show("输入名为空！");
                if (password == null || password == "")
                    MessageBox.Show("输入密码不能为空！");

                //通过设置公共类app在窗体之间传递参数

                if (manager.Id == id && manager.Psw == password)
                {
                    app.a = 1;
                    app.user_name = manager.Name;
                    app.user_id = manager.Id;
                    app.user_office = "管理层";
                    app.user_jobtitle = "管理者";
                   
                    Form1 form1 = new Form1();
                    this.Hide();
                    if (form1.ShowDialog()==DialogResult.OK) {
                        this.Close();
                    }
                }
                else
                {
                    DTO4DoctorInfo doctor = mgr.DoctorLogin(id);
                    if (doctor.Psw == password)
                    {
                        app.a = 0;

                        app.user_name = doctor.Name;
                        app.user_id = doctor.Id;
                        app.user_office = doctor.Office;
                        app.user_jobtitle = doctor.JobTitle;

                        Form1 form1 = new Form1();
                        this.Hide();
                        if (form1.ShowDialog() == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("登录失败");

                    }
                }
            }
            catch
            {
                MessageBox.Show("请确认您的账户密码是否正确");
            }

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
    public class app
    {
        public static int a;
        public static string user_name;
        public static string user_id;
        public static string user_office;
        public static string user_jobtitle;
    }

}

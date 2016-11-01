using System;
using System.Windows.Forms;

namespace demo_Hospital_scheduling
{
    public class HostPanel
    {
        private static Panel hostPanel;
        public static Form1 formMain;

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="frmName"></param>
        /// //FormMain.cs的ribbonBtn_Click事件调用这个方法，将要显示的panel和窗体名传给ShowForm
        public static Form ShowForm(Panel panel,string frmfile, string frmName)
        {
            hostPanel = panel;
            Form form = null;
            for (int i = 0; i < hostPanel.Controls.Count; i++)  // hostPanel里面可能加载了多个窗体
            {

                if (hostPanel.Controls[i].Tag.ToString() == frmName)
                {
                    form = (Form)hostPanel.Controls[i];  //查找Panel控件是否已有要显示的窗体
                    //break;
                }
            }

            if (form == null)
            {
                try
                {
                    form = AddForm(frmName,frmfile ,"demo_Hospital_scheduling");//若hostpanel没有加载窗体，
                                                                        //则进入AddForm方法，加载并显示窗体
                }
                catch (Exception ex)
                {
                    MessageBox.Show("生成窗体界面异常:" + ex.Message);
                    return null;
                }
            }
            //显示
            form.BringToFront(); //如果hostpanel已经加载了这个窗体，直接显示即可
            form.Show();

            return form;
        }
        //生成form实例并把Form添加Panel容器中
        private static Form AddForm(string frmName, string frmfile, string frmPlace)
        {
            try
            {
                Type type = Type.GetType(frmPlace + "." + frmfile + "." + frmName + "," + frmPlace);//找到要生成的类demo_Hospital_scheduling.窗体名

                Form FormFun =(Form)Activator.CreateInstance(type);//使用指定类型的默认构造函数来创造该类型的实例。创建窗体实例

                FormFun.Owner = formMain;//窗体的所属类
                FormFun.TopLevel = false;//设置为非顶级控件
                FormFun.FormBorderStyle = FormBorderStyle.None;//窗体边界样式不显示
                hostPanel.AutoScroll = true;//有滚动条
                FormFun.Dock = DockStyle.Fill;

                FormFun.Tag = frmName;//标签值

                hostPanel.Controls.Add(FormFun);//对panel添加窗体

                return FormFun;//返回窗体
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Enity;
using System.Windows.Forms;

namespace BLL
{
    public class BUser
    {

        //通过登录界面输入的账号密码来查询在数据库中是否存在这条数据，借此判断账号密码是否正确

        public DTO4ManagerInfo ManagerLogin(string id, string password)
        {
            DAO4ManagerInfo mDao = new DAO4ManagerInfo();
            DTO4ManagerInfo manager = mDao.selectAllByIdAndPsw(id, password);
            if (manager != null)
            {
                return manager;
            }
            else
            {
                throw new Exception("登录失败");
            }
        }
        public DTO4DoctorInfo DoctorLogin(string id)
        {
            DAO4DoctorInfo dDao = new DAO4DoctorInfo();
            DTO4DoctorInfo doctor = dDao.selectAllById(id);
            if (doctor != null)
            {
                return doctor;
            }
            else
            {
                throw new Exception("登录失败");
            }
        }
        public DTO4Arrangement getarrangment(int row, int cell, DataGridView dataGridView1, DateTimePicker dateTimePicker1, ComboBox comboBox1)
        {
            DTO4Arrangement arrangement = new DTO4Arrangement();
            DAO4DoctorInfo dDAO = new DAO4DoctorInfo();
            try
            {
                arrangement.DoctorName = dataGridView1.Rows[row].Cells[cell].Value.ToString();
                arrangement.Office = comboBox1.SelectedValue.ToString();
                DTO4DoctorInfo doctor = dDAO.selectAllByNameAndOffice(arrangement.DoctorName, arrangement.Office);

                //根据排班表的行数来判断该医生是早班还是中班还是晚班

                if (row<7)
                {
                    arrangement.BeginTime = Convert.ToDateTime(dataGridView1.Rows[0].Cells[cell].Value.ToString() + " 08:00:00");
                    arrangement.FinishTime = Convert.ToDateTime(dataGridView1.Rows[0].Cells[cell].Value.ToString() + " 14:00:00");
                }
                else if (row<13)
                {
                    arrangement.BeginTime = Convert.ToDateTime(dataGridView1.Rows[0].Cells[cell].Value.ToString() + " 14:00:00");
                    arrangement.FinishTime = Convert.ToDateTime(dataGridView1.Rows[0].Cells[cell].Value.ToString() + " 20:00:00");
                }
                else 
                {
                    arrangement.BeginTime = Convert.ToDateTime(dataGridView1.Rows[0].Cells[cell].Value.ToString() + " 20:00:00");
                    arrangement.FinishTime = Convert.ToDateTime(dataGridView1.Rows[0].Cells[cell].Value.ToString() + " 23:59:59");
                }
                arrangement.DoctorId = doctor.Id;
                arrangement.DoctorJobTitle = doctor.JobTitle;

                return arrangement;
        }
            catch {
                return null;
            }
}
    }
}

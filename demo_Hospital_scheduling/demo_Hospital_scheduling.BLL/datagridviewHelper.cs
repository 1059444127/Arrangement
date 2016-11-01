using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enity;

namespace demo_Hospital_scheduling.BLL
{
    public class datagridviewHelper
    {
        public void Search(DataGridView dataGridView1, ComboBox comboBox1)
        {
            datagridviewHelper dg = new datagridviewHelper();
            dg.CleanDataGridView(dataGridView1);

            string _strWorkingDayAftern = "14:00";//早于此时间段班次为早班
            string _strWorkingDayNig = "20:00";//介于14-20为午班，否则为晚班 
            TimeSpan dspWorkingDayAftern = TimeSpan.Parse(_strWorkingDayAftern);
            TimeSpan dspWorkingDayNig = TimeSpan.Parse(_strWorkingDayNig);

            for (int i = 1; i < 8; i++)
            {
                DateTime t = DateTime.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());//分别取周一到周日的日期

                Barrangement Ba = new Barrangement();
                DTO4Arrangement[] dto4 = new DTO4Arrangement[10];//科室每天排班上限为10名医生
                for (int z = 0; z < 10; z++)
                {
                    dto4[z] = new DTO4Arrangement();
                }


                dto4 = Ba.QueryArrangementByOfficeAndBeginTime(t, comboBox1.SelectedValue.ToString());

                int morn = 1, aftern = 7, nig = 13;//不同班次对应行号
                try
                {
                    for (int j = 0; j < dto4.Count(); j++)
                    {
                        if ((dto4[j].BeginTime - t) < dspWorkingDayAftern)//显示早班
                        {
                            dataGridView1.Rows[morn].Cells[i].Value = dto4[j].DoctorName;//将对应医生姓名放置到对应日期的早班，并换行
                            morn++;
                        }
                        else if ((dto4[j].BeginTime - t) < dspWorkingDayNig)//显示晚班
                        {
                            dataGridView1.Rows[aftern].Cells[i].Value = dto4[j].DoctorName;//将对应医生姓名放置到对应日期的中班，并换行
                            aftern++;
                        }
                        else//显示晚班
                        {
                            dataGridView1.Rows[nig].Cells[i].Value = dto4[j].DoctorName;//将对应医生姓名放置到对应日期的晚班，并换行
                            nig++;
                        }
                    }
                }
                catch { }
            }
        }


        public void CleanDataGridView(DataGridView dataGridView1)   //清空排班表
        {
            for(int i=1; i < 19; i++)
            {
                for (int j=1;j < 8;j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = null;
                }
            }
        }

        public void InsertArrangement(DataGridView dataGridView1,ComboBox comboBox1,ComboBox comboBox2)
        {
            string begin, end;
            if (dataGridView1.CurrentCell.RowIndex < 7)
            {
                begin = " 08:00:00";
                end = " 14:00:00";
            }
            else if (dataGridView1.CurrentCell.RowIndex < 13)
            {
                begin = " 14:00:00";
                end = " 20:00:00";
            }
            else
            {
                begin = " 20:00:00";
                end = " 23:59:59";
            }

            DateTime bT = DateTime.Parse(dataGridView1.Rows[0].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() + begin);
            DateTime fT = DateTime.Parse(dataGridView1.Rows[0].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() + end);

            Barrangement Ba = new Barrangement();

            Bdoctorinfo Bd = new Bdoctorinfo();
            DTO4DoctorInfo adddoctorinfo = new DTO4DoctorInfo();
            adddoctorinfo = Bd.QuaryDoctorinfoByNameAndOffice(comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString());
            try
            {
                Ba.AddArrangement(bT, fT, adddoctorinfo.Id, adddoctorinfo.Office, adddoctorinfo.Name, adddoctorinfo.JobTitle);
                dataGridView1.CurrentCell.Value = comboBox2.SelectedValue.ToString();//立即显示修改
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        public void UpdateArrangement(DataGridView dataGridView1, ComboBox comboBox1, ComboBox comboBox2)
        {
            string begin, end;
            if (dataGridView1.CurrentCell.RowIndex < 7)
            {
                begin = " 08:00:00";
                end = " 14:00:00";
            }
            else if (dataGridView1.CurrentCell.RowIndex < 13)
            {
                begin = " 14:00:00";
                end = " 20:00:00";
            }
            else
            {
                begin = " 20:00:00";
                end = " 23:59:59";
            }

            DateTime bT = DateTime.Parse(dataGridView1.Rows[0].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() + begin);
            DateTime fT = DateTime.Parse(dataGridView1.Rows[0].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() + end);

            Barrangement Ba = new Barrangement();
            string arrangementId = Ba.QueryArrangementIdByDoctorNameAndBeginTime(dataGridView1.CurrentCell.Value.ToString(), bT).Id;

            Bdoctorinfo Bd = new Bdoctorinfo();
            DTO4DoctorInfo updatedoctorinfo = new DTO4DoctorInfo();
            updatedoctorinfo = Bd.QuaryDoctorinfoByNameAndOffice(comboBox2.SelectedValue.ToString(), comboBox1.SelectedValue.ToString());
            try
            {
                Ba.UpdateById(arrangementId, bT, fT, updatedoctorinfo.Id, updatedoctorinfo.Office, updatedoctorinfo.Name, updatedoctorinfo.JobTitle);
                dataGridView1.CurrentCell.Value = comboBox2.SelectedValue.ToString();//立即显示修改
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DelectArrangement(DataGridView dataGridView1)
        {
            string begin;
            if (dataGridView1.CurrentCell.RowIndex < 7)
            {
                begin = " 08:00:00";             
            }
            else if (dataGridView1.CurrentCell.RowIndex < 13)
            {
                begin = " 14:00:00";
            }
            else
            {
                begin = " 20:00:00";
            }

            DateTime bT = DateTime.Parse(dataGridView1.Rows[0].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() + begin);
            Barrangement Ba = new Barrangement();
            string arrangementId = Ba.QueryArrangementIdByDoctorNameAndBeginTime(dataGridView1.CurrentCell.Value.ToString(), bT).Id;
            try
            {
                Ba.DelById(arrangementId);
                dataGridView1.CurrentCell.Value = null;//立即显示修改
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string[] ShowChangeRecord(DataGridView dataGridView1,ComboBox comboBox1,int z)       //显示申请记录
        {
            string[] ChangeRecordIds=new string[20];
            dataGridView1.Rows.Clear();
            string status;
            if (comboBox1.Text.ToString() == "已处理的申请")
            {
                status = "processed";
            }
            else
            {
                status = "untreated";
            }

            Barrangement ba = new Barrangement();
            Bchangerecord bc = new Bchangerecord();
            DTO4ChangeRecord[] dto4c = new DTO4ChangeRecord[20];
            DTO4Arrangement dto4a = new DTO4Arrangement();
            dto4c = bc.QueryChangerecordByStatus(status);
            int j=0;
            for (int i = 0; i < dto4c.Count(); i++)
            {               
                if (dto4c[i].ArrangementId_others=="0"&&z==1)
                {
                    int index = dataGridView1.Rows.Add(1);
                    dto4a = ba.QueryArrangementById(dto4c[i].ArrangementId_self);
                    dataGridView1.Rows[j].Cells[0].Value = dto4a.DoctorName;
                    dataGridView1.Rows[j].Cells[1].Value = dto4a.BeginTime;
                    dataGridView1.Rows[j].Cells[2].Value = dto4c[i].Remark;
                    ChangeRecordIds[j]=dto4c[i].Id;
                    j++;
                }              
                if(dto4c[i].ArrangementId_others!="0"&&z==0) 
                {
                    int index = dataGridView1.Rows.Add(1);
                    DTO4Arrangement dto4a_others = new DTO4Arrangement();
                    dto4a = ba.QueryArrangementById(dto4c[i].ArrangementId_self);                   
                    dto4a_others = ba.QueryArrangementById(dto4c[i].ArrangementId_others);
                    dataGridView1.Rows[j].Cells[0].Value = dto4a.DoctorName;
                    dataGridView1.Rows[j].Cells[1].Value = dto4a_others.DoctorName;
                    dataGridView1.Rows[j].Cells[2].Value = dto4a.BeginTime;
                    dataGridView1.Rows[j].Cells[3].Value = dto4a_others.BeginTime;
                    dataGridView1.Rows[j].Cells[4].Value = dto4c[i].Remark;
                    ChangeRecordIds[j] = dto4c[i].Id;
                    j++;
                }    
            }return ChangeRecordIds;
        }

        public void Execution(CheckBox checkBox4,CheckBox checkBox3,DataGridView dataGridView1,TextBox textBox1,string[] Ids,int z)//执行申请管理操作
        {
            string operate;
            Bchangerecord bc = new Bchangerecord();
            
            if (checkBox4.Checked)
            {
                if (z==0)       //自动执行调班处理；
                {
                    Barrangement ba = new Barrangement();
                    DTO4Arrangement self_arrangement = new DTO4Arrangement();
                    DTO4Arrangement others_arrangement = new DTO4Arrangement();
                    DateTime begin_time, finish_time;
                    self_arrangement = ba.QueryArrangementIdByDoctorNameAndBeginTime(dataGridView1.CurrentRow.Cells[0].Value.ToString(),DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                    others_arrangement = ba.QueryArrangementIdByDoctorNameAndBeginTime(dataGridView1.CurrentRow.Cells[1].Value.ToString(), DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()));
                    begin_time = self_arrangement.BeginTime;
                    finish_time = self_arrangement.FinishTime;
                    ba.UpdateById(self_arrangement.Id, others_arrangement.BeginTime, others_arrangement.FinishTime, self_arrangement.DoctorId, self_arrangement.Office, self_arrangement.DoctorName, self_arrangement.DoctorJobTitle);
                    ba.UpdateById(others_arrangement.Id,begin_time,finish_time,others_arrangement.DoctorId,others_arrangement.Office,others_arrangement.DoctorName,others_arrangement.DoctorJobTitle);
                    MessageBox.Show("已成功将"+self_arrangement.DoctorName+"与"+others_arrangement.DoctorName+"的班次对调！");
                }
                operate = "approve";
                bc.UpdateChangeRecordById(Ids[dataGridView1.CurrentCell.RowIndex], "processed", textBox1.Text, operate);
                MessageBox.Show("处理成功！");
            }
            else if (checkBox3.Checked)
            {
                operate = "disapprove";
                bc.UpdateChangeRecordById(Ids[dataGridView1.CurrentCell.RowIndex], "processed", textBox1.Text, operate);
                MessageBox.Show("处理成功！");
            }
            else
            {
                MessageBox.Show("请先选择处理结果：批准/不批准");
            }
        }

        public void tiaoban_application(string user_name, DateTimePicker dateTimePicker2,DateTimePicker dateTimePicker4, ComboBox comboBox3 ,TextBox textBox1)
        {
            int arrangementId_self, arrangementId_others;

            Barrangement ba = new Barrangement();
            Bchangerecord bc = new Bchangerecord();

            DTO4Arrangement dto4a_self = new DTO4Arrangement();
            dto4a_self = ba.QueryArrangementIdByDoctorNameAndBeginTime(user_name, dateTimePicker2.Value.Date);
            arrangementId_self = int.Parse(dto4a_self.Id);

            DTO4Arrangement dto4a_others = new DTO4Arrangement();
            dto4a_others = ba.QueryArrangementIdByDoctorNameAndBeginTime(comboBox3.SelectedValue.ToString(), dateTimePicker4.Value.Date);
            arrangementId_others = int.Parse(dto4a_others.Id);

            if (bc.InsertChangeRecord(arrangementId_self, arrangementId_others, textBox1.Text, "untreated"))
                MessageBox.Show("申请成功！");
            else
                MessageBox.Show("申请失败，请确认是否正确选择班次！");
        }

        public void qingjia_application(string user_name, DateTimePicker dateTimePicker3,TextBox textBox2)
        {
            int arrangementId_self;

            Barrangement ba = new Barrangement();
            Bchangerecord bc = new Bchangerecord();

            DTO4Arrangement dto4a_self = new DTO4Arrangement();
            dto4a_self = ba.QueryArrangementIdByDoctorNameAndBeginTime(user_name, dateTimePicker3.Value.Date);
            arrangementId_self = int.Parse(dto4a_self.Id);

            if (bc.InsertChangeRecord(arrangementId_self, 0, textBox2.Text, "untreated"))
                MessageBox.Show("申请成功！");
            else
                MessageBox.Show("申请失败，请确认是否正确选择班次！");
        }
    }
}

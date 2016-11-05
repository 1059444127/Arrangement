using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace demo_Hospital_scheduling.BLL
{
    public class showTime
    {
        public static void show(DataGridView dataGridView1,DateTimePicker dateTimePicker1)
        {
            switch (dateTimePicker1.Value.DayOfWeek.ToString())
            {
                case "Monday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 1).ToShortDateString();
                    }
                    break;
                case "Tuesday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 2).ToShortDateString();
                    }
                    break;
                case "Wednesday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 3).ToShortDateString();
                    }
                    break;
                case "Thursday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 4).ToShortDateString();
                    }
                    break;
                case "Friday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 5).ToShortDateString();
                    }
                    break;
                case "Saturday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 6).ToShortDateString();
                    }
                    break;
                case "Sunday":
                    for (int i = 1; i < 8; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = dateTimePicker1.Value.AddDays(+i - 7).ToShortDateString();
                    }
                    break;
                default:
                    break;
            }
        }


        public static void showAPM(DataGridView dataGridView1)
        {
            int index = dataGridView1.Rows.Add(18);            //显示时间段
            dataGridView1.Rows[0].Cells[0].Value = "日期";
            dataGridView1.Rows[1].Cells[0].Value = "早";
            dataGridView1.Rows[10].Cells[0].Value = "晚";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)    //分区改变单元格背景颜色
            {
                if (i % 2 == 0 || i == 0)
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                else
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
    }
}

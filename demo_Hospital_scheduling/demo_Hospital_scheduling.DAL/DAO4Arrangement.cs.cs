using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Enity;
/// <summary>
/// Author: chenzhaoquan
/// Version: v1.0
/// Date : 2016-10-8
/// ClassName: DAO4Arrangement
/// </summary>
/// <remark>
/// 本类用于对Arrangement表的基本操作：
/// 1.按排班表id查找排班表信息
/// 2.按医生id查找排班表信息
/// 3.按姓名查找排班信息（模糊查找）
/// 4.按科室名称查找排班信息
/// 5.按职称名称查找排班信息
/// 6.按照职称/科室/名字查找排班信息（模糊查找）
/// 7.按照排班表id删除排班记录
/// 8.新增排班记录
/// 9.按照开始时间和科室查找排班记录
/// </remark>
namespace DAL
{
    public class DAO4Arrangement
    {

        /// <summary>
        /// 按排班表id查找排班表信息
        /// </summary>
        /// <param name="_id">string id</param>
        /// <returns>DTO4Arrangement对象</returns>
        public DTO4Arrangement selectAllById(string _id)
        {
            string sql = "select * from arrangement where id = " + _id;
            DataSet dt = DBOperater.selectSql(sql);
            DTO4Arrangement dto4a = new DTO4Arrangement();
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {              
                dto4a.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4a.Office = (string)dt.Tables[0].Rows[0]["office"];
                dto4a.BeginTime = (DateTime)dt.Tables[0].Rows[0]["beginTime"];
                dto4a.FinishTime = (DateTime)dt.Tables[0].Rows[0]["finishTime"];
                dto4a.DoctorId = dt.Tables[0].Rows[0]["doctorId"].ToString();
                dto4a.DoctorName = (string)dt.Tables[0].Rows[0]["doctorName"];
                dto4a.DoctorJobTitle = (string)dt.Tables[0].Rows[0]["doctorJobTitle"];
            }
            return dto4a;
        }

        /// <summary>
        /// 按医生id查找排班表信息
        /// </summary>
        /// <param name="_doctorId">string doctorId</param>
        /// <returns>DTO4Arrangement对象数组</returns>
        public DTO4Arrangement[] selectAllByDoctorId(string _doctorId)
        {
            string sql = "select * from arrangement where id = " + _doctorId;
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4aArray[i] = new DTO4Arrangement();
                    dto4aArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4aArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4aArray[i].BeginTime = (DateTime)dt.Tables[0].Rows[i]["beginTime"];
                    dto4aArray[i].FinishTime = (DateTime)dt.Tables[0].Rows[i]["finishTime"];
                    dto4aArray[i].DoctorId = dt.Tables[0].Rows[i]["doctorId"].ToString();
                    dto4aArray[i].DoctorName = (string)dt.Tables[0].Rows[i]["doctorName"];
                    dto4aArray[i].DoctorJobTitle = (string)dt.Tables[0].Rows[i]["doctorJobTitle"];
                }
                return dto4aArray;
            }
            else
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[1];
                return dto4aArray;
            }

        }

        /// <summary>
        /// 按姓名查找排班信息（模糊查找）
        /// </summary>
        /// <param name="_doctorName">string doctorName</param>
        /// <returns>DTO4Arrangement对象数组</returns>
        public DTO4Arrangement[] selectAllByDoctorName(string _doctorName)
        {
            string sql = "select * from arrangement where doctorName like '%" + _doctorName + "%'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4aArray[i] = new DTO4Arrangement();
                    dto4aArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4aArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4aArray[i].BeginTime = (DateTime)dt.Tables[0].Rows[i]["beginTime"];
                    dto4aArray[i].FinishTime = (DateTime)dt.Tables[0].Rows[i]["finishTime"];
                    dto4aArray[i].DoctorId = dt.Tables[0].Rows[i]["doctorId"].ToString();
                    dto4aArray[i].DoctorName = (string)dt.Tables[0].Rows[i]["doctorName"];
                    dto4aArray[i].DoctorJobTitle = (string)dt.Tables[0].Rows[i]["doctorJobTitle"];
                }
                return dto4aArray;
            }
            else
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[1];
                return dto4aArray;
            }

        }

        /// <summary>
        /// 按科室名称查找排班信息
        /// </summary>
        /// <param name="_office">string office</param>
        /// <returns>DTO4Arrangement对象数组</returns>
        public DTO4Arrangement[] selectAllByOffice(string _office)
        {
            string sql = "select * from arrangement where office = '" + _office + "'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4aArray[i] = new DTO4Arrangement();
                    dto4aArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4aArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4aArray[i].BeginTime = (DateTime)dt.Tables[0].Rows[i]["beginTime"];
                    dto4aArray[i].FinishTime = (DateTime)dt.Tables[0].Rows[i]["finishTime"];
                    dto4aArray[i].DoctorId = dt.Tables[0].Rows[i]["doctorId"].ToString();
                    dto4aArray[i].DoctorName = (string)dt.Tables[0].Rows[i]["doctorName"];
                    dto4aArray[i].DoctorJobTitle = (string)dt.Tables[0].Rows[i]["doctorJobTitle"];
                }
                return dto4aArray;
            }
            else
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[1];
                return dto4aArray;
            }
        }

        /// <summary>
        /// 按职称名称查找排班信息
        /// </summary>
        /// <param name="_doctorJobTitle">string _doctorJobTitle</param>
        /// <returns>DTO4Arrangement对象数组</returns>
        public DTO4Arrangement[] selectAllByDoctorJobTitle(string _doctorJobTitle)
        {
            string sql = "select * from arrangement where doctorJobTitle = '" + _doctorJobTitle + "'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4aArray[i] = new DTO4Arrangement();
                    dto4aArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4aArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4aArray[i].BeginTime = (DateTime)dt.Tables[0].Rows[i]["beginTime"];
                    dto4aArray[i].FinishTime = (DateTime)dt.Tables[0].Rows[i]["finishTime"];
                    dto4aArray[i].DoctorId = dt.Tables[0].Rows[i]["doctorId"].ToString();
                    dto4aArray[i].DoctorName = (string)dt.Tables[0].Rows[i]["doctorName"];
                    dto4aArray[i].DoctorJobTitle = (string)dt.Tables[0].Rows[i]["doctorJobTitle"];
                }
                return dto4aArray;
            }
            else
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[1];
                return dto4aArray;
            }
        }
        //
        /// <summary>
        /// 按照职称/科室/名字查找排班信息（模糊查找）
        /// </summary>
        /// <param name="_doctorJobTitle">string _doctorJobTitle</param>
        /// <param name="_office">string _office</param>
        /// <param name="_doctorName">string _doctorName</param>
        /// <returns>DTO4Arrangement对象数组</returns>
        public DTO4Arrangement[] selectAllByDoctorJobTitleAndOfficeAndDoctorName(string _doctorJobTitle, string _office, string _doctorName)
        {
            string sql = "select * from arrangement where doctorJobTitle = '" + _doctorJobTitle + "' and office = '" + _office + "' and doctorName like '%" + _doctorName + "%'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4aArray[i] = new DTO4Arrangement();
                    dto4aArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4aArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4aArray[i].BeginTime = (DateTime)dt.Tables[0].Rows[i]["beginTime"];
                    dto4aArray[i].FinishTime = (DateTime)dt.Tables[0].Rows[i]["finishTime"];
                    dto4aArray[i].DoctorId = dt.Tables[0].Rows[i]["doctorId"].ToString();
                    dto4aArray[i].DoctorName = (string)dt.Tables[0].Rows[i]["doctorName"];
                    dto4aArray[i].DoctorJobTitle = (string)dt.Tables[0].Rows[i]["doctorJobTitle"];
                }
                return dto4aArray;
            }
            else
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[1];
                return dto4aArray;
            }
        }


        /// <summary>
        /// 按照排班表id删除排班记录
        /// </summary>
        /// <param name="_id">string id</param>
        /// <returns>int flag</returns>
        public int deleteAllById(string _id)
        {
            string sql = "delete from arrangement where id = " + _id;
            return DBOperater.executeSql(sql);
        }

        /// <summary>
        /// 按照id修改排班表记录
        /// </summary>
        /// <param name="_id">string id</param>
        /// <param name="_beginTime">DateTime begibTime</param>
        /// <param name="_finishTime">DateTime finshTime</param>
        /// <param name="_doctorId">string doctorId</param>
        /// <param name="_office">string office</param>
        /// <param name="_doctorName"> string doctorName</param>
        /// <param name="_doctorJobTitle">string doctorJobTitle</param>
        /// <returns>int flag</returns>
        public int updateAllById(string _id, DateTime _beginTime, DateTime _finishTime, string _doctorId, string _office, string _doctorName, string _doctorJobTitle)
        {
            string sql = "update arrangement set beginTime = '" + _beginTime + "',finishTime = '" + _finishTime + "',doctorId = " + _doctorId + ",office = '" + _office + "',doctorName = '" + _doctorName + "',doctorJobTitle = '" + _doctorJobTitle + "' where id = " + _id;
            return DBOperater.executeSql(sql);
        }

        /// <summary>
        /// 新增排班表记录
        /// </summary>
        /// <param name="_id"></param>
        /// <param name="_beginTime"></param>
        /// <param name="_finishTime"></param>
        /// <param name="_doctorId"></param>
        /// <param name="_office"></param>
        /// <param name="_doctorName"></param>
        /// <param name="_doctorJobTitle"></param>
        /// <returns>int flag</returns>
        public int insertArrangement(DateTime _beginTime, DateTime _finishTime, string _doctorId, string _office, string _doctorName, string _doctorJobTitle)
        {
            string sql = "insert into arrangement(beginTime,finishTime,doctorId,office,doctorName,doctorJobTitle) values ( '" + _beginTime + "','" + _finishTime + "'," + _doctorId + ",'" + _office + "','" + _doctorName + "','" + _doctorJobTitle + "')";
            return DBOperater.executeSql(sql);
        }

        /// <summary>
        /// 按开始时间和科室查找排班表信息
        /// </summary>
        /// <param name="_doctorId">DateTime doctorId</param>
        /// <returns>DTO4Arrangement对象数组</returns>
        public DTO4Arrangement[] selectAllByBeginTime(DateTime _beginTime, string _office)
        {
            string sql = "select * from arrangement where convert(varchar,beginTime,120) like '%" + _beginTime.ToString("yyyy-MM-dd") + "%' and office ='" + _office + "'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt!=null&&dt.Tables.Count>0&&dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4aArray[i] = new DTO4Arrangement();
                    dto4aArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4aArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4aArray[i].BeginTime = (DateTime)dt.Tables[0].Rows[i]["beginTime"];
                    dto4aArray[i].FinishTime = (DateTime)dt.Tables[0].Rows[i]["finishTime"];
                    dto4aArray[i].DoctorId = dt.Tables[0].Rows[i]["doctorId"].ToString();
                    dto4aArray[i].DoctorName = (string)dt.Tables[0].Rows[i]["doctorName"];
                    dto4aArray[i].DoctorJobTitle = (string)dt.Tables[0].Rows[i]["doctorJobTitle"];
                    //dto4aArray[i].Img = (string)dt.Tables[0].Rows[i]["img"];
                }
                return dto4aArray;
            }
            else
            {
                DTO4Arrangement[] dto4aArray = new DTO4Arrangement[1];
                return dto4aArray;
            }

        }

        public DTO4Arrangement selectArrangementIdByNameAndBegintime(string _name,DateTime _beginTime)
        {
            string sql = "select * from arrangement where convert(varchar,beginTime,120) like '%" + _beginTime.ToString("yyyy-MM-dd") + "%' and doctorName ='" + _name + "'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4Arrangement dto4 = new DTO4Arrangement();
                dto4.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4.Office = (string)dt.Tables[0].Rows[0]["office"];
                dto4.BeginTime = (DateTime)dt.Tables[0].Rows[0]["beginTime"];
                dto4.FinishTime = (DateTime)dt.Tables[0].Rows[0]["finishTime"];
                dto4.DoctorId = dt.Tables[0].Rows[0]["doctorId"].ToString();
                dto4.DoctorName = (string)dt.Tables[0].Rows[0]["doctorName"];
                dto4.DoctorJobTitle = (string)dt.Tables[0].Rows[0]["doctorJobTitle"];

                return dto4;
            }
            else
            {
                DTO4Arrangement dto4 = new DTO4Arrangement();
                return dto4;
            }
        }


    }
}


       

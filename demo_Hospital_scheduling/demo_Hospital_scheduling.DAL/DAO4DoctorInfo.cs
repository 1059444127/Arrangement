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
/// Date : 2016-10-6
/// ClassName: DAO4DoctorInfo
/// </summary>
/// <remark>
/// 本类用于对doctorInfo表的基本操作：
/// 1.通过id查找医生信息
/// 2.通过id和密码查找医生信息
/// 3.按科室和职称查询医生信息（模糊查找）
/// 4.查询有哪几个科室
/// 5.根据科室名称查找当前科室里医生有哪几种职称
/// </remark>
namespace DAL
{
    public class DAO4DoctorInfo
    {
        /// <summary>
        /// 通过id查找医生信息
        /// </summary>
        /// <param name="_id">string类型 医生id</param>
        /// <returns>DTO4DoctorInfo的对象</returns>
        public DTO4DoctorInfo selectAllById(string _id)
        {
            string sql = "select * from doctorInfo where id =" + _id;
            DataSet dt = DBOperater.selectSql(sql);
            DTO4DoctorInfo dto4d = new DTO4DoctorInfo();
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                dto4d.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4d.Name = (string)dt.Tables[0].Rows[0]["name"];
                dto4d.JobTitle = (string)dt.Tables[0].Rows[0]["jobTitle"];
                dto4d.Office = (string)dt.Tables[0].Rows[0]["office"];
                dto4d.Psw = (string)dt.Tables[0].Rows[0]["psw"];
                dto4d.Upper = dt.Tables[0].Rows[0]["upper"].ToString();
                dto4d.Gender = (string)dt.Tables[0].Rows[0]["gender"];
                //dto4d.Birth = dt.Tables[0].Rows[0]["birth"];
            }
            return dto4d;

        }
        /// <summary>
        /// 通过id,psw查找医生信息
        /// </summary>
        /// <param name="_id">string类型 医生id</param>
        /// <param name="_psw">string类型 医生密码</param>
        /// <returns>DTO4DoctorInfo的对象</returns>
        public DTO4DoctorInfo selectAllByIdAndPsw(string _id, string _psw)
        {
            string sql = "select * from doctorInfo where id =" + _id + " and psw = '" + _psw + "'";
            DataSet dt = DBOperater.selectSql(sql);
            DTO4DoctorInfo dto4d = new DTO4DoctorInfo();
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                dto4d.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4d.Name = (string)dt.Tables[0].Rows[0]["name"];
                dto4d.JobTitle = (string)dt.Tables[0].Rows[0]["jobTitle"];
                dto4d.Office = (string)dt.Tables[0].Rows[0]["office"];
                dto4d.Psw = (string)dt.Tables[0].Rows[0]["psw"];
                dto4d.Upper = dt.Tables[0].Rows[0]["upper"].ToString();
                dto4d.Gender = (string)dt.Tables[0].Rows[0]["gender"];
                dto4d.Birth = (DateTime)dt.Tables[0].Rows[0]["birth"];
            }
            return dto4d;
        }
        /// <summary>
        /// 查询有哪几个科室
        /// </summary>
        /// <returns>DataSet类型 Rows[n]["office"]</returns>
        public DataSet selectOffice()
        {
            string sql = "select DISTINCT office from doctorInfo";
            return DBOperater.selectSql(sql);
        }

        /// <summary>
        /// 根据科室名称查找当前科室里医生有哪几种职称
        /// </summary>
        /// <param name="_office">string类型 科室名称</param>
        /// <returns>DataSet类型 Rows[n]["jobTitle"]</returns>
        public DataSet selectJobTitleByOffice(string _office)
        {
            string sql = "select distinct jobTitle from doctorInfo where office = '" + _office + "'";
            return DBOperater.selectSql(sql);
        }

        /// <summary>
        /// 按科室和职称查询医生信息（模糊查找）
        /// </summary>
        /// <param name="_office">string类型 科室名称</param>
        /// <param name="_jobTitle">string类型 职称名称</param>
        /// <returns>DTO4DoctorInfo的对象数组</returns>
        public DTO4DoctorInfo[] selectAllByJobTitleAndOffice(string _office, string _jobTitle)
        {
            string sql = "select * from doctorInfo where office like '%" + _office + "%' and jobTitle like '%" + _jobTitle + "%'";
            DataSet dt = DBOperater.selectSql(sql);

            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {

                DTO4DoctorInfo[] dto4dArray = new DTO4DoctorInfo[dt.Tables[0].Rows.Count];
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4dArray[i] = new DTO4DoctorInfo();
                    dto4dArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4dArray[i].Name = (string)dt.Tables[0].Rows[i]["name"];
                    dto4dArray[i].JobTitle = (string)dt.Tables[0].Rows[i]["jobTitle"];
                    dto4dArray[i].Office = (string)dt.Tables[0].Rows[i]["office"];
                    dto4dArray[i].Psw = (string)dt.Tables[0].Rows[i]["psw"];
                    dto4dArray[i].Upper =dt.Tables[0].Rows[i]["upper"].ToString();
                    dto4dArray[i].Gender = (string)dt.Tables[0].Rows[i]["gender"];
                    dto4dArray[i].Birth = (DateTime)dt.Tables[0].Rows[i]["birth"];
                }
                return dto4dArray;
            }
            else
            {
                DTO4DoctorInfo[] dto4dArray = new DTO4DoctorInfo[1];
                return dto4dArray;
            }

        }

        public DataSet selectNameByOffice(string _office)       //2016/10/9  新增功能查询医生姓名By科室
        {
            string sql = "select distinct name from doctorInfo where office =  '" + _office + "'";
            return DBOperater.selectSql(sql);
        }

        //按医生姓名和科室查找医生信息
        public DTO4DoctorInfo selectAllByNameAndOffice(string _name, string _office)
        {
            string sql = "select * from doctorInfo where name ='" + _name + "' and office ='" + _office + "'";
            DataSet dt = DBOperater.selectSql(sql);
            DTO4DoctorInfo dto4d = new DTO4DoctorInfo();
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                dto4d.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4d.Name = (string)dt.Tables[0].Rows[0]["name"];
                dto4d.JobTitle = (string)dt.Tables[0].Rows[0]["jobTitle"];
                dto4d.Office = (string)dt.Tables[0].Rows[0]["office"];
                dto4d.Psw = (string)dt.Tables[0].Rows[0]["psw"];
                dto4d.Upper = dt.Tables[0].Rows[0]["upper"].ToString();
                dto4d.Gender = (string)dt.Tables[0].Rows[0]["gender"];
            }
            return dto4d;
        }
     
    }
}

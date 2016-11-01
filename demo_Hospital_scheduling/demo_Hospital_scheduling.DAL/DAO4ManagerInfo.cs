using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Enity;
using System.Windows.Forms;
/// <summary>
/// Author: chenzhaoquan
/// Version: v1.0
/// Date : 2016-10-6
/// ClassName: DAO4Managerment
/// </summary>
/// <remark>
/// 本类用于对mangerment表的基本操作：
/// 1.通过id和密码查找管理员信息
/// </remark>
namespace DAL
{
    public class DAO4ManagerInfo
    {
        /// <summary>
        /// 通过id和密码查找管理员信息
        /// </summary>
        /// <param name="_id">string类型 管理员id</param>
        /// <param name="_psw">string类型 管理员密码</param>
        /// <returns>DTO4ManagerInfo类型的对象</returns>
        public DTO4ManagerInfo selectAllByIdAndPsw(string _id, string _psw)
        {
            string sql = "select * from managerInfo where id =" + _id + " and psw = '" + _psw + "'";
            DTO4ManagerInfo dto4m = new DTO4ManagerInfo();
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                dto4m.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4m.Name = (string)dt.Tables[0].Rows[0]["name"];
                dto4m.Psw = (string)dt.Tables[0].Rows[0]["psw"];
            }
            return dto4m;


        }

    }
}
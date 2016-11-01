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
/// ClassName: DAO4ChangeRecord
/// </summary>
/// <remark>
/// 本类用于对changeRecord表的基本操作：
/// 1.通过id和密码查找管理员信息
/// </remark>
namespace DAL
{
    public class DAO4ChangeRecord
    {
        /// <summary>
        /// 根据状态查找排班修改记录
        /// </summary>
        /// <param name="_status">string 状态</param>
        /// <returns></returns>
        public DTO4ChangeRecord[] selectAllByStatus(string _status)
        {
            String sql = "select * from changeRecord where status = '" + _status + "'";
            DataSet dt = DBOperater.selectSql(sql);
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                DTO4ChangeRecord[] dto4cArray = new DTO4ChangeRecord[dt.Tables[0].Rows.Count];

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    dto4cArray[i] = new DTO4ChangeRecord();
                    dto4cArray[i].Id = dt.Tables[0].Rows[i]["id"].ToString();
                    dto4cArray[i].ArrangementId_self = dt.Tables[0].Rows[i]["arrangementId_self"].ToString();
                    dto4cArray[i].ArrangementId_others = dt.Tables[0].Rows[i]["arrangementId_others"].ToString();
                    dto4cArray[i].Status = (string)dt.Tables[0].Rows[i]["status"];
                    dto4cArray[i].Remark = (string)dt.Tables[0].Rows[i]["remark"];
                    dto4cArray[i].Operate = dt.Tables[0].Rows[i]["operate"].ToString();

                }
                return dto4cArray;
            }
            else
            {
                DTO4ChangeRecord[] dto4cArray = new DTO4ChangeRecord[1];
                return dto4cArray;
            }
        }
        //根据排班表id查找排班修改记录
        /// <summary>
        /// 根据排班表id查找排班修改记录
        /// </summary>
        /// <param name="_arrangementId">string 排班表id</param>
        /// <returns></returns>
        public DTO4ChangeRecord selectAllByArrangementId(string _arrangementId_self)
        {
            String sql = "select * from changeRecord where arrangementId_self = " + _arrangementId_self;
            DataSet dt = DBOperater.selectSql(sql);
            DTO4ChangeRecord dto4c = new DTO4ChangeRecord();
            if (dt != null && dt.Tables.Count > 0 && dt.Tables[0].Rows.Count > 0)
            {
                dto4c.Id = dt.Tables[0].Rows[0]["id"].ToString();
                dto4c.ArrangementId_self = (string)dt.Tables[0].Rows[0]["arrangementId_self"];
                dto4c.Status = (string)dt.Tables[0].Rows[0]["status"];
                dto4c.Remark = (string)dt.Tables[0].Rows[0]["remark"];
                dto4c.Operate = (string)dt.Tables[0].Rows[0]["operate"];
            }
            return dto4c;
        }
        //新增一条排班表修改记录
        public int insertChangeRecord(int _arrangementId_self,int _arrangementId_others, string _remark, string _status)
        {
            string sql = "insert into changeRecord(arrangementId_self,arrangementId_others,remark,status) values ('"+_arrangementId_self +"','"+_arrangementId_others+ "','" + _remark + "','" + _status+ "')";
            return DBOperater.executeSql(sql);
        }
        //根据记录id修改状态和备注
        public int updateStatusAndRemarkById(string _id, string _status, string _remark, string _operate)
        {
            string sql = "update changeRecord set status = '" + _status + "',remark = '" + _remark + "',operate ='" + _operate +"'  where id =" + _id;
            return DBOperater.executeSql(sql);
        }
    }
}
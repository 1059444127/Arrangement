using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Enity;
using DAL;

namespace demo_Hospital_scheduling.BLL
{
    public class Bchangerecord
    {
        private DAO4ChangeRecord changerecord = new DAO4ChangeRecord();

        // 根据状态查找排班修改记录
        public DTO4ChangeRecord[] QueryChangerecordByStatus(string status)
        {
            return changerecord.selectAllByStatus(status);
        }

        //根据排班表id查找排班修改记录
        public DTO4ChangeRecord QueryChangerecordById(string id)
        {
            return changerecord.selectAllByArrangementId(id);
        }

        //新增一条排班表修改记录
        public bool InsertChangeRecord(int arrangementId_self, int arrangementId_others, string remark, string status)
        {
            if(changerecord.insertChangeRecord(arrangementId_self,arrangementId_others,remark,status)==1)//通过返回flag值判断是否执行成功；
            { return true; }
            else
            { return false; }
        }

        //根据记录id修改状态和备注
        public bool UpdateChangeRecordById(string id, string status, string remark,string operate)
        {
            if(changerecord.updateStatusAndRemarkById(id,status,remark,operate)==1)//通过返回flag值判断是否执行成功；
            { return true; }
            else
            { return false; }
        }

    }
}

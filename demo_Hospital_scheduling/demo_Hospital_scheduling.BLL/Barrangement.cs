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
    public class Barrangement
    {
        private DAO4Arrangement arrangement = new DAO4Arrangement();

        //按排班表id查找排班表信息
        public DTO4Arrangement QueryArrangementById(string id)
        {
            return arrangement.selectAllById(id);
        }

        //按医生id查找排班表信息
        public DTO4Arrangement[] QueryArrangementByDoctorId(string doctorId)
        {
            return arrangement.selectAllByDoctorId(doctorId);
        }

        //按姓名查找排班信息（模糊查找）
        public DTO4Arrangement[] QueryArrangementByDoctorName(string doctorName)
        {
            return arrangement.selectAllByDoctorName(doctorName);
        }

        //按科室名称查找排班信息
        public DTO4Arrangement[] QueryArrangementByOffice(string office)
        {
            return   arrangement.selectAllByOffice(office);
            
        }

        //按职称名称查找排班信息
        public DTO4Arrangement[] QueryArrangementByDoctorJobTitle(string doctorJobTitle)
        {
            return arrangement.selectAllByDoctorJobTitle(doctorJobTitle);
        }

        //按照职称/科室/名字查找排班信息（模糊查找）
        public DTO4Arrangement[] QueryArrangementByDoctorJobTitleAndOfficeAndDoctorName(string doctorJobTitle, string office, string doctorName)
        {
            return arrangement.selectAllByDoctorJobTitleAndOfficeAndDoctorName(doctorJobTitle, office, doctorName);
        }

        //按照排班表id删除排班记录
        public bool DelById(string id)
        {
            if (arrangement.deleteAllById(id) == 1)//通过返回flag值判断是否执行成功；
            { return true; }
            else
            { return false; }
        }

        //按照id修改排班表记录
        public bool UpdateById(string id, DateTime beginTime, DateTime finishTime, string doctorId, string office, string doctorName, string doctorJobTitle)
        {
            if (arrangement.updateAllById(id, beginTime, finishTime, doctorId, office, doctorName, doctorJobTitle) == 1)//通过返回flag值判断是否执行成功；
            { return true; }
            else
            { return false; }
        }

        //按科室和开始时间查询排班表
        public DTO4Arrangement[] QueryArrangementByOfficeAndBeginTime(DateTime begintime,string office)
        {
            return arrangement.selectAllByBeginTime(begintime, office);
        }

        //新增排班信息
        public int AddArrangement( DateTime beginTime, DateTime finishTime, string doctorId, string office, string doctorName, string doctorJobTitle)
        {
            return arrangement.insertArrangement(beginTime,finishTime,doctorId,office,doctorName,doctorJobTitle);
        }

        public DTO4Arrangement QueryArrangementIdByDoctorNameAndBeginTime(string name,DateTime beginTime)
        {
            return arrangement.selectArrangementIdByNameAndBegintime(name,beginTime);
        }
    }
}

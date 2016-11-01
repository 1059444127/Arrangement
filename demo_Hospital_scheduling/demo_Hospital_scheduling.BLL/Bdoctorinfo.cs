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
    public class Bdoctorinfo
    {
        private DAO4DoctorInfo doctorinfo = new DAO4DoctorInfo();

        // 通过id查找医生信息
        public DTO4DoctorInfo QuaryDoctorinfoById(string id)
        {
             return doctorinfo.selectAllById(id);
        }

        // 通过id查找医生信息
        public DTO4DoctorInfo QuaryDoctorinfoByIdandPsw(string id,string psw)
        {
            return doctorinfo.selectAllByIdAndPsw(id, psw);
        }

        // 查询有哪几个科室
        public DataSet QuaryOffice()
        {
            return doctorinfo.selectOffice();
        }

        // 根据科室名称查找当前科室里医生有哪几种职称
        public DataSet QuaryJobTitlesByOffice(string office)
        {
            return doctorinfo.selectJobTitleByOffice(office);
        }

        // 按科室和职称查询医生信息（模糊查找）
        public DTO4DoctorInfo[] QuaryDoctorinfoByJobTitleAndOffice(string jobtitle,string office)
        {
            return doctorinfo.selectAllByJobTitleAndOffice(jobtitle, office);
        }

        public DataSet QuaryDoctorNameByOffice(string office)//2016/10/9    新增功能查询医生姓名By科室
        {
            return doctorinfo.selectNameByOffice(office);
        }

        public DTO4DoctorInfo QuaryDoctorinfoByNameAndOffice(string name,string office)
        {
            return doctorinfo.selectAllByNameAndOffice(name,office);
        }
    }
}

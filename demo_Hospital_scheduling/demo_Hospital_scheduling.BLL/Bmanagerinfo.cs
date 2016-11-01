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
    public class Bmanagerinfo
    {
        private DAO4ManagerInfo managerinfo = new DAO4ManagerInfo();

        // 通过id和密码查找管理员信息
        public DTO4ManagerInfo QuarymanagerinfoByIdAndPsw(string id, string psw)
        {
            return managerinfo.selectAllByIdAndPsw(id,psw);
        }

    }
}

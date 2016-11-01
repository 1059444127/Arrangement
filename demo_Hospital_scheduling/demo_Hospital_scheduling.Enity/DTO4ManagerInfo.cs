using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author: chenzhaoquan
/// Version: v1.0
/// Date : 2016-10-6
/// ClassName: DTO4Managerment
/// </summary>
/// <remark>
/// 本类为数据传输而创立，所有属性初始值为默认值;
/// </remark>
namespace Enity
{
    public class DTO4ManagerInfo
    {
        /// <summary>
        /// 私有属性和managerment表字段一一对应;
        /// </summary>
        private string id;
        private string name;
        private string psw;


        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Psw
        {
            get
            {
                return psw;
            }

            set
            {
                psw = value;
            }
        }


    }
}

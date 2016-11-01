using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Author: chenzhaoquan
/// Version: v1.0
/// Date : 2016-10-6
/// ClassName: DTO4DoctorInfo
/// </summary>
/// <remark>
/// 本类为数据传输而创立，所有属性初始值为默认值;
/// </remark>
namespace Enity
{
    public class DTO4DoctorInfo
    {
        private string id;
        private string name;
        private string office;
        private string jobTitle;
        private string upper;
        private string psw;
        private string gender;
        private DateTime birth;

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

        public string Office
        {
            get
            {
                return office;
            }

            set
            {
                office = value;
            }
        }

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }

            set
            {
                jobTitle = value;
            }
        }

        public string Upper
        {
            get
            {
                return upper;
            }

            set
            {
                upper = value;
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

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public DateTime Birth
        {
            get
            {
                return birth;
            }

            set
            {
                birth = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enity
{
    public class DTO4ChangeRecord
    {

        private string id;
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

        private string arrangementId_self;
        public string ArrangementId_self
        {
            get
            {
                return arrangementId_self;
            }

            set
            {
                arrangementId_self = value;
            }
        }

        private string arrangementId_others;
        public string ArrangementId_others
        {
            get
            {
                return arrangementId_others;
            }

            set
            {
                arrangementId_others = value;
            }
        }

        private string operate;
        public string Operate
        {
            get
            {
                return operate;
            }

            set
            {
                operate = value;
            }
        }

        private string remark;
        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        private string status;




    }
}
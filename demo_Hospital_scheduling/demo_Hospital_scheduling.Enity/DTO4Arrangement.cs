using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enity
{

    public class DTO4Arrangement
    {
        private string id;
        private DateTime beginTime;
        private DateTime finishTime;
        private string doctorId;
        private string office;
        private string doctorName;
        private string doctorJobTitle;
        private string img;
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

        public DateTime BeginTime
        {
            get
            {
                return beginTime;
            }

            set
            {
                beginTime = value;
            }
        }

        public DateTime FinishTime
        {
            get
            {
                return finishTime;
            }

            set
            {
                finishTime = value;
            }
        }

        public string DoctorId
        {
            get
            {
                return doctorId;
            }

            set
            {
                doctorId = value;
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

        public string DoctorName
        {
            get
            {
                return doctorName;
            }

            set
            {
                doctorName = value;
            }
        }

        public string DoctorJobTitle
        {
            get
            {
                return doctorJobTitle;
            }

            set
            {
                doctorJobTitle = value;
            }
        }

        public string Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }
    }
}
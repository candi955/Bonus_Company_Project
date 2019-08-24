using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace companyBonusProject
{
    class Hiring : PointsOfContact
    {
        // Field for Derived Class, Hiring
        private string staffing;

        // Constructor for Staffing
        public Hiring()
        {
            staffing = "Janice Krasowitz (763)234-8271";
        }

        public string Staffing
        {
            get { return staffing; }
            set { staffing = value; }
        }
    }
}


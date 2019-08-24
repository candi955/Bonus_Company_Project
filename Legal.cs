using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace companyBonusProject
{
    class Legal : PointsOfContact
    {
        // Field for Derived Class, Legal
        private string corporateAttorney;

        // Constructor for CorporateAttorney
        public Legal()
        {
            corporateAttorney = "Dan Robbins (917)309-8712";
        }

        public string CorporateAttorney
        {
            get { return corporateAttorney; }
            set { corporateAttorney = value; }
        }
    }
}

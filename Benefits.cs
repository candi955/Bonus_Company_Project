using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace companyBonusProject
{
    class Benefits : PointsOfContact
    {
        // Field for Derived Class, Benefits
        private string lifeInsurancePOC;

        // Constructor for LifeInsurance
        public Benefits()
        {
            lifeInsurancePOC = "Bill Wagoner (345)789-1234";
        }

        public string LifeInsurancePOC
        {
            get { return lifeInsurancePOC; }
            set { lifeInsurancePOC = value; }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace companyBonusProject
{
    class PointsOfContact
    {
        // Fields for Base Class Points of Contact
        private string frontDesk;
        private string secretary;
        private string lead;      

        // Constructor for PointsOfContact
        public PointsOfContact()
        {
            frontDesk = "";
            secretary = "";
            lead = "";
         
        }

        // Modifications

        public string FrontDesk
        {
            get { return frontDesk; }
            set { frontDesk = value; }
        }

        public string Secretary
        {
            get { return secretary; }
            set { secretary = value; }
        }

        public string Lead
        {
            get { return lead; }
            set { lead = value; }
        }


           
    }
}

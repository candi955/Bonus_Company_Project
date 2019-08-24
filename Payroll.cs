using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace companyBonusProject
{
    class Payroll : PointsOfContact
    {
        // Field for Derived Class, Payroll
        private string accountsManager;

        // Constructor for Accounts Manager
        public Payroll()
        {
            accountsManager = "Debbie Rothschild (555)444-3333";
        }

        public string AccountsManager
        {
            get { return accountsManager; }
            set { accountsManager = value;}
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace companyBonusProject
{
    public partial class HumanResources : Form
    {

        class Supervisor
        {
            private string supervisor;

            public Supervisor(string updatedSup)
            {
                supervisor = updatedSup;
            }
            public string AccessToSup()
            { return supervisor; }

        }
        public HumanResources()
        {
            InitializeComponent();
        }

        private void payrollButton_Click(object sender, EventArgs e)
        {
            // Create and object for Payroll

            Payroll myAccountsManager = new Payroll();
            myAccountsManager.FrontDesk = "Janice Walker (111)222-3333";
            myAccountsManager.Secretary = "Johnny Krazowitz (111)888-4444";
            myAccountsManager.Lead = "Kim Johnson (111)666-8888";
            

            // Create  Payroll Instance

            

            HRLabel.Text = ("Front Desk: " + myAccountsManager.FrontDesk + "\n" + "\n" +
                "Secretary: " + myAccountsManager.Secretary + "\n" + "\n" + "Lead: " +
                myAccountsManager.Lead + "\n" + "\n" + "Accounts Manager: " + myAccountsManager.AccountsManager);
        }

        private void benefitsButton_Click(object sender, EventArgs e)
        {
            // Create and object for Benefits

            Benefits myBenefits = new Benefits();
            myBenefits.FrontDesk = "Connie Yonkers (111)666-2222";
            myBenefits.Secretary = "Don Basolow (111)777-9999";
            myBenefits.Lead = "Robbie Watkins (111)345-6789";


            // Create  Benefits Instance



            HRLabel.Text = ("Front Desk: " + myBenefits.FrontDesk + "\n" + "\n" +
                "Secretary: " + myBenefits.Secretary + "\n" + "\n" + "Lead: " +
                myBenefits.Lead + "\n" + "\n" + "Life Insurance: " + myBenefits.LifeInsurancePOC);
        }

        private void hiringButton_Click(object sender, EventArgs e)
        {
            // Create and object for Hiring

            Hiring myHiring = new Hiring();
            myHiring.FrontDesk = "Alex Bonns (111)932-0892";
            myHiring.Secretary = "Elizabeth Akers (111)847-9382";
            myHiring.Lead = "Jose Benavides (111)243-2367";


            // Create Hiring Instance



            HRLabel.Text = ("Front Desk: " + myHiring.FrontDesk + "\n" + "\n" +
                "Secretary: " + myHiring.Secretary + "\n" + "\n" + "Lead: " +
                myHiring.Lead + "\n" + "\n" + "Staffing: " + myHiring.Staffing);
        }

        private void legalButton_Click(object sender, EventArgs e)
        {
            // Create and object for Legal

            Legal myLegal = new Legal();
            myLegal.FrontDesk = "James Watson (111)364-0132";
            myLegal.Secretary = "MaryJane Azaur (111)938-3421";
            myLegal.Lead = "Cassandra Dominquez-Walker (111)243-2367";


            // Create Hiring Instance



            HRLabel.Text = ("Front Desk: " + myLegal.FrontDesk + "\n" + "\n" +
                "Secretary: " + myLegal.Secretary + "\n" + "\n" + "Lead: " +
                myLegal.Lead + "\n" + "\n" + "Corporate Attorney: " + myLegal.CorporateAttorney);
        }
    }
}

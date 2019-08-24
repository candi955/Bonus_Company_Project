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
    public partial class DetailsForm : Form
    {
        public DetailsForm()
        {
            InitializeComponent();
        }

        private void jobsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jobsTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employmentDataSet1);

        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employmentDataSet1.jobsTable' table. You can move, or remove it, as needed.
            this.jobsTableTableAdapter.Fill(this.employmentDataSet1.jobsTable);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}

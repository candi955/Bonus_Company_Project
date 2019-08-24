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
    public partial class vacationPlanningForm : Form
    {
        public vacationPlanningForm()
        {
            InitializeComponent();
        }
        // Set up Sequential Search
        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

            while (!found && index < sArray.Length)
            {
                if (sArray[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            return position;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vacationPlanningListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection; // To hold selection
            string[] instructions = { "Tahiti" };
            string[] nova_scotia = { "Nova Scotia" };
            string[] china = { "China" };
            string[] italy = { "Italy" };


            if (vacationPlanningListBox.SelectedIndex != -1)
            {
                // Get the selected item
                selection = vacationPlanningListBox.SelectedItem.ToString();

                if (SequentialSearch(instructions, selection) != -1)
                {
                    vacationPlanningLabel.Text = ("1) Bring a bathing suit.\n" + "2) Bring a beach towel.\n" +
                        "3) Don't forget sun screen.");
                }
                else if (SequentialSearch(nova_scotia, selection) != -1)
                {
                    vacationPlanningLabel.Text = ("1) Bring a few sweaters.\n" + "2) Bring waterproof shoes.\n" +
                        "3) Hot-Hands products are optional.");
                }
                else if (SequentialSearch(china, selection) != -1)
                {
                    vacationPlanningLabel.Text = ("1) Bring universal plugs for your electronics.\n" +
                        "2) Make sure you have room for souvenirs.\n" + "3) Pack a light jacket.");
                }
                else if (SequentialSearch(italy, selection) != -1)
                {
                    vacationPlanningLabel.Text = ("1) Bring a hat.\n" +
                        "2) Make sure you have a passport.\n" + "3) Bring a bathing suit.");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            vacationPlanningLabel.Text = "";
        }
    }
}


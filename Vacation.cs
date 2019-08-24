using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace companyBonusProject
{
    public partial class Vacation : Form
    {
        String[] name_vacation = new string[5];
        
        public Vacation()
        {
            InitializeComponent();
        }
        // Set up SequentialSearch
        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;

        while (!found && index < sArray.Length)
            {
                if(sArray[index] == value)
                {
                    found = true;
                    position = index;
                }

                index++;
            }

            return position;
        }
        
           
        


        private void submitButton_Click(object sender, EventArgs e)
        {          
                        
            name_vacation[0] = firstNameTextBox.Text;
            name_vacation[1] = lastNameTextBox.Text;
            name_vacation[2] = choice1TextBox.Text;
            name_vacation[3] = choice2TextBox.Text;
            name_vacation[4] = choice3TextBox.Text;
                        

            string nameVacayList = "";
            for (int i= 0; i < 5; i++)
            {
                nameVacayList += name_vacation[i];
            }
            
            try
            {                
                StreamWriter outputFile;
                outputFile = File.AppendText("vacationWishes.txt");

                outputFile.WriteLine("Name: " + name_vacation[0] + ", " + name_vacation[1] + "\n" +
                    "Vacation choice 1: " + name_vacation[2] + "\n" + "Vacation choice 2: " +
                    name_vacation[3] + "\n" + "Vacation choice 3: " + name_vacation[4] + "\n");

                outputFile.Close();

                MessageBox.Show("Thank you for your submission");

                // Clearing the textboxes

                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
                choice1TextBox.Text = "";
                choice2TextBox.Text = "";
                choice3TextBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void vehicleExchangeInstructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void vacationPlanningButton_Click(object sender, EventArgs e)
        {






            }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            choice1TextBox.Text = "";
            choice2TextBox.Text = "";
            choice3TextBox.Text = "";

            firstNameTextBox.Focus();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

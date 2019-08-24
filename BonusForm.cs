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
    public partial class BonusForm : Form
    {
        public BonusForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Define the variable of company annual profit entry monetarily
            decimal profit;

            // Define the variable for the bonus answer in string form
            decimal bonus_answer;

            //making attempts to add if and else statement for exceptions
            bool parsed = decimal.TryParse(profitAnswerLabel.Text, out profit);


            //Get the profit and assign it to the profit variable


            if (decimal.TryParse(profitEntryTextBox.Text, out profit))
            {
                MessageBox.Show("Your annual bonus will show " + "\n" +
                    "in the 'Bonus this year:' box");
            }
            else
            {
                MessageBox.Show("Thank you for your entry. Please make sure it is in decimal format in order for this calculator to work properly.");
            }
            try
            {
                profit = Convert.ToDecimal(profit);
            }
            catch
            {
                MessageBox.Show("Please make sure there is decimal format prior to submission.");
            }

            // Calculate bonus

            bonus_answer = (profit / 10);

            // Display the bonus_answer in the profitAnswerLabel
            profitAnswerLabel.Text = bonus_answer.ToString("#,##0.00");


            //if, else if, else

            if (profit <= 100_000)
            {
                profitAnswerLabel.Text = ("$0");

            }
            else if (profit > 100_000 && profit <= 200_000)
            {
                profit = decimal.Parse(profitAnswerLabel.Text);
                profitAnswerLabel.Text = ("Good job! You get" + " " + "$" + bonus_answer.ToString("#,##0.00"));
            }
            else
            {
                profitAnswerLabel.Text = "We are all rich now.  Let's retire.";

                try
                {
                    // Declare a StreamWriter variable
                    StreamWriter outputFile;

                    // Open the writeCodeToFile.txt file for appending
                    // and get a StreamWriter object.
                    outputFile = File.CreateText("bonusToFile.txt");

                    outputFile.WriteLine(profitAnswerLabel.Text);

                    // Close the file.
                    outputFile.Close();

                    // Let the user know the text was written.
                    MessageBox.Show("Thank you. Your answer has been " + "\n" + 
                        "submitted to Human Resources.");

                    // Clear the profit answer label control
                    profitAnswerLabel.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);



                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            profitEntryTextBox.Text = "";
            profitAnswerLabel.Text = "";
            profitEntryTextBox.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BonusForm_Load(object sender, EventArgs e)
        {

        }
    }
}


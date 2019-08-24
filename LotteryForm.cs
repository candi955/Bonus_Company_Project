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
    public partial class LotteryForm : Form
    {
        public LotteryForm()
        {
            InitializeComponent();
        }

        private void lotteryButton_Click(object sender, EventArgs e)
        {
            int random_num = 0;


            Random rand = new Random();
            int[] Lottery = new int[1];

            for (int i = 0; i < Lottery.Length;)
            {
                random_num = rand.Next(0, 100);
                Lottery[i] = random_num;
                i++;

                numberPickedLabel.Text = random_num.ToString();

                actualBonusLabel.Text = "We regret to inform you that you will not receive a bonus this year.";

                //Attempting a While Loop to allow User to try again if zero pops up

                while (numberPickedLabel.Text == "0")
                {
                    MessageBox.Show("You picked zero randomly.  We are going to give you another try.  Click again please.");

                    numberPickedLabel.Text = "";
                    random_num++;
                }


                {

                }

                if (random_num == 0 + 32)
                {
                    actualBonusLabel.Text = "Congratulations, you will receive a $20,000 bonus this year!";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numberPickedLabel.Text = "";
            actualBonusLabel.Text = "";
            numberPickedLabel.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


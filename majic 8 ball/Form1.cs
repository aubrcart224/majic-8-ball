using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace majic_8_ball
{
    public partial class Form1 : Form
    {
        //global variables 
        Random randGen = new Random();



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variaboles 
            int number;
            number = randGen.Next(1, 7);

            // if statement (switch)
            
            switch (number)
            {
                case 1:
                    outputLabel.Text = "no";
                    break;
                case 2:
                    outputLabel.Text = "possibly";
                    break;
                case 3:
                    outputLabel.Text = "most definitly";
                    break;
                case 4:
                    outputLabel.Text = "you have no future";
                    break;
                case 5:
                    outputLabel.Text = "perhaps";
                    break;
                case 6:
                    outputLabel.Text = "do you think so?";
                    break;

            }
            
        }
    }
}

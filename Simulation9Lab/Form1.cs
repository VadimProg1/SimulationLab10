using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulation9Lab
{
    public partial class Form1 : Form
    {
        private decimal prob8 = 0;
        private BasicSensor rnd = new BasicSensor();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsProbsOk())
            {
                label_result.Text = "";
                decimal[] probs = new decimal[8] { 
                    numericUpDown_prob1.Value,
                    numericUpDown_prob2.Value,
                    numericUpDown_prob3.Value,
                    numericUpDown_prob4.Value,
                    numericUpDown_prob5.Value, 
                    numericUpDown_prob6.Value,
                    numericUpDown_prob7.Value,
                    prob8};

                double a = 0;
                double randNum = rnd.GetRandomNumber();
                for (int i = 0; i < probs.Length; i++)
                {
                    a += Convert.ToDouble(probs[i]);
                    if (a > randNum)
                    {
                        label_result.Text = "Выпала " + Convert.ToString(i + 1) + " Грань";
                        break;
                    }
                }
            }
            else
            {
                label_result.Text = "You entered incorrect probs";
            }
        }
        
        private bool IsProbsOk()
        {
            decimal p = numericUpDown_prob1.Value + numericUpDown_prob2.Value
                + numericUpDown_prob3.Value + numericUpDown_prob4.Value 
                + numericUpDown_prob5.Value + numericUpDown_prob6.Value
                + numericUpDown_prob7.Value;
            if(p < 1)
            {
                prob8 = 1 - p;
                return true;
            }
            return false;
        }
    }
}

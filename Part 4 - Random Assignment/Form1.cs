using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Assignment
{
    public partial class RandomNumbers : Form
    {
        Random generator = new Random();
        int rounding;
        int max;
        int min;
        public RandomNumbers()
        {
            InitializeComponent();
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int rando;

            min = Convert.ToInt32(txtMin.Text);           
            max = Convert.ToInt32(txtMax.Text);

            rando = generator.Next(min, max+1);

            lblOutput.Text = rando + "";
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double rando;

            min = Convert.ToInt32(txtMin.Text);
            max = Convert.ToInt32(txtMax.Text);

            rando = generator.NextDouble() * (1+max - min) + min;
            rounding = Convert.ToInt32(txtRound.Text);
            rando = Math.Round(rando, rounding);

            lblOutput.Text = rando + "";

        }
    }
}

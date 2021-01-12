using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class SetConstantsForm : Form
    {
        private Fractal app;

        private double maxCons = 2; // maximum and minimum constants for the function used in fractal.
        private double minCons = -2;

        public SetConstantsForm(Fractal appRef, double r, double i) // app reference, real value, imaginary value
        {
            InitializeComponent();

            this.app = appRef;

            this.realVal.Text = r.ToString();
            this.imaginaryVal.Text = i.ToString();
        }

        private void applyBtn_Click(object sender, EventArgs e) // apply the constant after validated
        {
            if (isDouble(this.realVal.Text) && isDouble(this.imaginaryVal.Text))
            {
                double r = double.Parse(this.realVal.Text);
                double i = double.Parse(this.imaginaryVal.Text);

                if ((r >= minCons && i >= minCons) && (r <= maxCons && i <= maxCons))
                {
                    this.app.applyCustomConstants(r, i);
                }
                else
                {
                    MessageBox.Show("Min value is " + this.minCons + " & Max value is " + this.maxCons, "Invalid", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Both real & imaginary values should be numeric", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool isDouble(String shouldBeDouble) // check if the passed string is double
        {
            double a;

            return double.TryParse(shouldBeDouble, out a);
        }
    }
}

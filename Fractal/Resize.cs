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
    public partial class Resize : Form
    {
        private Fractal app;

        private int iniWidth;
        private int iniHeight;

        private int minHeight;
        private int minWidth;

        private int maxHeight;
        private int maxWidth;

        public Resize(Fractal appRef, int w, int h, int minH, int minW, int maxH, int maxW)
        {
            InitializeComponent();

            this.app = appRef;
            this.iniWidth = w;
            this.iniHeight = h;

            setMinHeightWidth(minH, minW);

            setMaxHeightAndWidth(maxH, maxW);

            setDefaultHeightWidth();
        }

        private void setMinHeightWidth(int minH, int minW)
        {
            this.minHeight = minH;
            this.minWidth = minW;
        }

        private void setMaxHeightAndWidth(int minH, int minW)
        {
            this.maxHeight = minH;
            this.maxWidth = minW;
        }

        private void setDefaultHeightWidth()
        {
            this.heightVal.Text = this.iniHeight.ToString();
            this.widthVal.Text = this.iniWidth.ToString();
        }

        private void widthVal_TextChanged(object sender, EventArgs e)
        {
            if (isInteger(widthVal.Text))
            {
                numericErrorProvider.SetError(this.widthVal, String.Empty);

                if (this.widthVal.Focused && this.maintainAspectRatio.Checked)
                {
                    this.heightVal.Text = this.getProportionalHeight().ToString();
                }
            }
            else
            {
                numericErrorProvider.SetError(this.widthVal, "Only numerical values allowed!!");
            }
        }

        private void heightVal_TextChanged(object sender, EventArgs e)
        {
            if (isInteger(heightVal.Text))
            {
                numericErrorProvider.SetError(this.heightVal, String.Empty);

                if (this.heightVal.Focused && this.maintainAspectRatio.Checked)
                {
                    this.widthVal.Text = this.getProportionalWidth().ToString();
                }
            }
            else
            {
                numericErrorProvider.SetError(this.heightVal, "Only numerical values allowed!!");
            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            int h, w;

            if (isInteger(this.heightVal.Text) && isInteger(this.widthVal.Text))
            {
                h = int.Parse(this.heightVal.Text);
                w = int.Parse(this.widthVal.Text);

                if ((h >= minHeight && w >= minHeight) && (h <= maxHeight && w <= maxWidth))
                {
                    this.app.applyCustomSize(w, h);
                }
                else
                {
                    MessageBox.Show("Min height & width are " + this.minHeight + " & " + this.minWidth + ", Max height & width are " + this.maxHeight + " & " + this.maxWidth, "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private bool isInteger(String shouldBeInt)
        {
            int a;

            return (int.TryParse(shouldBeInt, out a));
        }

        private int getProportionalWidth()
        {
            return (int.Parse(this.heightVal.Text) * iniWidth / iniHeight);
        }

        private int getProportionalHeight()
        {
            return (int.Parse(this.widthVal.Text) * iniHeight / iniWidth);
        }
    }
}

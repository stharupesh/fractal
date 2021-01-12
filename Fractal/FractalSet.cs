using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal
{
    abstract class FractalSet
    {
        protected int x, y;
        protected float h, b, alt;

        public double SX; // start value real
        public double SY; // start value imaginary
        public double EX;    // end value real
        public double EY;  // end value imaginary

        public double consR;
        public double consI;

        protected Pen pen;
        protected HSB HSBcol;

        public FractalSet()
        {

        }

        public abstract void draw(Graphics g, int x1, int y1, double xs, double ys, double xz, double yz, int max);

        public abstract float calculateHue(double xwert, double ywert, int max); // moving x and y point while iterating each coordinate / pixel, max iteration
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal
{
    class JuliaSet : FractalSet
    {
        public JuliaSet() // app reference
        {
            SX = -2; // start value real
            SY = -1.6; // start value imaginary
            EX = 1.6;    // end value real
            EY = 1.125;  // end value imaginary

            consR = - 0.7; // constant real value
            consI = 0.27015; // constant imaginary value

            this.HSBcol = new HSB();

            this.pen = new Pen(Color.White);
        }

        public override void draw(Graphics g, int x1, int y1, double xs, double ys, double xz, double yz, int max)
        {
            alt = 0.0f;

            for (x = 0; x < x1; x += 2)
            {
                for (y = 0; y < y1; y++)
                {
                    h = calculateHue(xs + xz * (double)x, ys + yz * (double)y, max); // hue value

                    if (h != alt)
                    {
                        b = 1.0f - h * h; // brightness

                        Color col = HSBcol.setHSBValues(h, 0.8f, b) // converts hsb to rgb then return Color object
                                          .toRGB();

                        pen = new Pen(col);

                        alt = h;
                    }

                    g.DrawLine(pen, new Point(x, y), new Point(x + 1, y)); // drawing pixel
                }


            }
        }

        public override float calculateHue(double xwert, double ywert, int max) // moving x and y point while iterating each coordinate / pixel, max iteration
        {
            double r = xwert, i = ywert, m = 0.0; // r= real, i = imaginary and m = mandelbrot set, used for storing absolute value or distance

            int j = 0; // iteration

            while ((j < max) && (m < 4.0)) // while (( j is less than the max iteration) && (the output of the f(x) is inside the radius of 2 / inside mandelbrot set))
            {
                j++;

                // as the complex numbers are represented by (x, y) coordinate form so, for passing them to the function "f(x) = z^2 + c", (x^2 - y^2, 2xy) is used which calculates z^2

                m = r * r - i * i; // x^2 - y^2
                i = 2.0 * r * i + consI; // 2xy + c where c is constant
                r = m + consR; // xwert is constant
            }

            return (float)j / (float)max; // hue value according to the ratio of number of possible iterations and max iterations.
        }
    }
}

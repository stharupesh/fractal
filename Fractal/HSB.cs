using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Fractal
{
    class HSB
    {
        private float hue, sat, bri; // hue, saturation and brightness value

        public HSB()
        {

        }

        public HSB(float h, float s, float b)
        {
            this.setHSBValues(h, s, b);
        }

        public HSB setHSBValues(float h, float s, float b)
        {
            this.hue = h;
            this.sat = s;
            this.bri = b;

            return this; // for method chaining
        }

        public Color toRGB() // the HSB class provided in the java program didn't convert the HSB to RGB properly so, the below code is used which is the conversion of core code of java's Color.getHSBColor() method.
        {
            float rVal = 0, gVal = 0, bVal = 0;

            if (sat == 0)
            {
                rVal = gVal = bVal = (int)(bri * 255.0f + 0.5f);
            }
            else
            {
                hue = ((hue - (float)Math.Floor(hue)) * 6.0f);
                
                float f = hue - (float)Math.Floor(hue); // fractional sector

                // calculating values for the three axes of the color
                float p = bri * (1.0f - sat);
                float q = bri * (1.0f - sat * f);
                float t = bri * (1.0f - (sat * (1.0f - f)));

                switch ((int) hue)
                {
                    case 0:
                        {
                            rVal = (int)(bri * 255.0f + 0.5f);
                            gVal = (int)(t * 255.0f + 0.5f);
                            bVal = (int)(p * 255.0f + 0.5f);
                        }
                        break;

                    case 1:
                        {
                            rVal = (int)(q * 255.0f + 0.5f);
                            gVal = (int)(bri * 255.0f + 0.5f);
                            bVal = (int)(p * 255.0f + 0.5f);
                        }
                        break;

                    case 2:
                        {
                            rVal = (int)(p * 255.0f + 0.5f);
                            gVal = (int)(bri * 255.0f + 0.5f);
                            bVal = (int)(t * 255.0f + 0.5f);
                        }
                        break;

                    case 3:
                        {
                            rVal = (int)(p * 255.0f + 0.5f);
                            gVal = (int)(q * 255.0f + 0.5f);
                            bVal = (int)(bri * 255.0f + 0.5f);
                        }
                        break;

                    case 4:
                        {
                            rVal = (int)(t * 255.0f + 0.5f);
                            gVal = (int)(p * 255.0f + 0.5f);
                            bVal = (int)(bri * 255.0f + 0.5f);
                        }
                        break;

                    case 5:
                        {
                            rVal = (int)(bri * 255.0f + 0.5f);
                            gVal = (int)(p * 255.0f + 0.5f);
                            bVal = (int)(q * 255.0f + 0.5f);
                        }
                        break;
                }
            }

            return Color.FromArgb(Convert.ToByte(rVal), Convert.ToByte(gVal), Convert.ToByte(bVal));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioAmCalc
{
    internal class Forms
    {
        /*
fRC = Math.Round(1/(2*Math.PI*(r*c))*1000,3);
fLC = Math.Round(1/(2*Math.PI*(Math.Sqrt(l*c)))*1000,3);
r = Math.Round(1 / (2 * Math.PI * (fLC * c)) * 1000, 2); нахождение R имея L и C
l = Math.Round((r * c * r),3); нахождение L имея R и C
c = Math.Round(1 / (Math.Pow(2 * Math.PI * fLC, 2) * l) * Math.Pow(10, 6), 3); нахождение C имея F и L
l = Math.Round(r / (2 * Math.PI * fLC),2); нахождение L имея F и R
*/
        public double FindfLC(double c, double l)
        {
            double fLC = Math.Round(1 / (2 * Math.PI * (Math.Sqrt(l * c))) * 1000, 3);
            return fLC;
        }
        public double FindL(double f, double c)
        {
            double r = Math.Round(1 / (2 * Math.PI * (f * c)), 2);
            double l = Math.Round((r * c * r), 2);
            return l;
        }

        public double FindC(double f, double l)
        {
            double c = Math.Round(1 / (Math.Pow(2 * Math.PI * f, 2) * l) * Math.Pow(10, 6), 3);
            return c;
        }

        public double FindR(double f, double c, double l)
        {
            double r = Math.Round(1 / (2 * Math.PI * (f * c)) * 1000, 2);
            return r;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public struct Equation
    {
        double k;
        double b;
        
        public Equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double Root()
        {
            return -b / k;
        }
    }
}

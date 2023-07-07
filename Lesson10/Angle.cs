using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    class Angle
    {
        int gradus;
        int min;
        int sec;

      public int Gradus
        { get { return gradus; } set {  gradus = value; } }
        public int Min
        { get { return min; } set {  min = value %60; Gradus += value / 60; } }
        public int Sec
        { get { return sec; } set {  sec = value %60; Min += value / 60; } }
        public Angle (int gradus, int min, int sec)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }

       
        public double ToRadians()
        {
            double rads =(gradus + min + sec)* Math.PI / 180;
            return rads;
        }
    }
}

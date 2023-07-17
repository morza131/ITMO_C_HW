using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {
        int startX;
        int current;        
        public int Step { get; set; }
        public int getNext()
        {
            current += Step;
            return current;
        }

        public void reset()
        {
            current = startX;
        }

        public void setStart(int x)
        {            
            startX = x;
            current = startX;
        }
    }
    class GeomProgression : ISeries
    {
        int startX;
        int current;
        
        public int Step { get; set; }
        public int getNext()
        {
            current *= Step;
            return current;
        }

        public void reset()
        {
            current= startX;
        }

        public void setStart(int x)
        {            
            startX = x;
            current = startX;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            arithProgression.setStart(3);
            arithProgression.Step = 3;
            Console.WriteLine("Арифметическая прогрессия");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine("Геометрическая прогрессия");
            geomProgression.setStart(3);
            geomProgression.Step = 3;
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
        }
    }
}

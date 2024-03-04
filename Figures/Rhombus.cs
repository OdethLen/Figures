using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rhombus : IFigure
    {

        double Side;
        double Diagonal1;
        double Diagonal2;
        public Rhombus(double side, double diagonal1, double diagonal2)
        {
            this.Side = side;
            this.Diagonal1 = diagonal1;
            this.Diagonal2 = diagonal2;
        }

        public  double Perimeter()
        {
            return Side * 4;
        }

        public double Area()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }


        public string PrintAreaR()
        {
            return "" + Area();
        }
        public string PrintPerimeterR()
        {
            return "" + Perimeter();
        }



    }
}

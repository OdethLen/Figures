using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal interface IFigure 
    {
        // Define a "contract" on which we can be sure that the classes that implement them will comply.
        double Area();
        double Perimeter();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading__Collections_Homework
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree = degree;
        }

        public static implicit operator Celsius(Kelvin kelvin) => new Celsius(kelvin.Degree - 273);
    }
}

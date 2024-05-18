using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.OCP.Before
{
    //states that once a functionality has been implemented,
    //if requirements change over time
    //that these changes are implemented by adding new code instead of modifying the code that already works

    //Example of a class that violates Open/Closed Principle :


    public class AreaCalculator
    {
        public double CalculateArea(string shapeType, double length, double width = 0)
        {
            if (shapeType == "Rectangle")
            {
                return length * width;
            }
            else if (shapeType == "Circle")
            {
                return Math.PI * length * length; 
            }
            else
            {
                throw new ArgumentException("Invalid shape type");
            }
        }
    }







}

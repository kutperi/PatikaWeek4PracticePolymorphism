using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PracticePolymorphism
{
    public class BaseGeometrikSekil // Creating a new class
    {
        public double Width { get; set; } // Defining properties

        public double Height { get; set; }

        
        public virtual void AreaCalculation() // Creating a virtual method that calculates area
        {
            Console.WriteLine($"Verilen şeklin alanı --> {Width * Height}");
        }

    }

    public class Kare() : BaseGeometrikSekil // Creating a new class that inherits from base class
    {
        public override void AreaCalculation() // Overriding first method for Kare class
        {
            Console.WriteLine($"Karenin alanı --> {Width * Height}");
        }
    }

    public class Dikdortgen() : BaseGeometrikSekil // Creating a new class that inherits from base class
    {
        public override void AreaCalculation() // Overriding first method for Dikdortgen class
        {
            Console.WriteLine($"Dikdörtgenin alanı --> {Width * Height}");
        }
    }

    public class DikUcgen() : BaseGeometrikSekil // Creating a new class that inherits from base class
    {
        public override void AreaCalculation() // Overriding first method for DikUcgen class
        {
            Console.WriteLine($"Dik üçgenin alanı --> {(Width * Height) / 2}");
        }
    }
}

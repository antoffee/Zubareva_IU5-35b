using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    /// <summary>
    /// Класс круг
    /// </summary>
    class Circle : Figure, IPrint
    {
        public double radius { set; get; }

        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круг";
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return this.Type + " радиусом " + this.radius.ToString() + ", площадью " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}

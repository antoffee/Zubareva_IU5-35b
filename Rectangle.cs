using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    class Rectangle : Figure, IPrint
    {
        public double width { get; set; }
        public double height { get; set; }
        /// <summary>
        /// Конструктор класса прямоугольник, инициализирует сначала ширину, потом высоту
        /// </summary>
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            return this.width * this.height;
        }
        public override string ToString()
        {
            return this.Type + " шириной " + this.width.ToString() + ", высотой " + this.height.ToString() + ", площадью " + this.Area().ToString();
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}

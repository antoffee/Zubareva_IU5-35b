using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    /// <summary>
    /// Класс квадрат
    /// </summary>
    class Square : Rectangle
    {
        public Square(double a)
            : base(a, a)
        {
            this.Type = "Квадрат";
        }

        public override string ToString()
        {
            return this.Type + " со стороной " + this.width.ToString() + ", площадью " + this.Area().ToString();
        }

    }
}

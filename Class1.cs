using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    abstract class Figure: IComparable
    {

        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        public abstract double Area();

        public override string ToString()
        {
            return this.Type + " площадью " + this.Area().ToString();
        }
        /// <summary>
        /// Сравнение элементов (для сортировки)
        /// this - левый параметр сравнения
        /// </summary>
        /// <param name="obj">правый параметр сравнения</param>
        /// <returns>
        /// -1 - если левый параметр меньше правого
        /// 0 - параметры равны
        /// 1 - правый параметр меньше левого
        /// </returns>
        public int CompareTo(object obj)
        {
            //Приведение параметра к типу "фигура"
            Figure p = (Figure)obj;
            //Сравнение
            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1; //(this.Area() > p.Area())
        }
    }
}

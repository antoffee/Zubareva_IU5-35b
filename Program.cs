using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------
            //создание объектов классов
            Rectangle rect = new Rectangle(5, 4);
            Square square = new Square(4);
            Circle circle = new Circle(5);

            //-----------------------------
            //создание коллекции класса ArrayList
            ArrayList arrayl = new ArrayList();
            arrayl.Add(rect);
            arrayl.Add(square);
            arrayl.Add(circle);
            Console.WriteLine("\nArrayList до сортировки:");
            foreach (var el in arrayl) Console.WriteLine(el);

            arrayl.Sort();
            Console.WriteLine("\nArrayList после сортировки:");
            foreach (var el in arrayl) Console.WriteLine(el);

            //-----------------------------------
            //создание коллекции класса List<Figure>
            List<Figure> listf = new List<Figure>();
            listf.Add(circle);
            listf.Add(rect);
            listf.Add(square);

            Console.WriteLine("\nList<Figure> до сортировки:");
            foreach (var el in listf) Console.WriteLine(el);

            listf.Sort();
            Console.WriteLine("\nList<Figure> после сортировки:");
            foreach (var el in listf) Console.WriteLine(el);

            //-----------------------------------------------------
            Console.WriteLine("\nМатрица");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 1] = square;
            matrix[2, 2, 2] = circle;
            Console.WriteLine(matrix.ToString());

            //Выход за границы индекса и обработка исключения
            try
            {
                Figure temp = matrix[123, 123, 123];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            //---------------------------------------------------
            Console.WriteLine("\nСтек");

            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            //добавление данных в стек
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            //чтение данных из стека
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
        }
    }
}

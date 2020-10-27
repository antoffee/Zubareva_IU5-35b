﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public interface IMatrixCheckEmpty<T>
    {
            /// <summary>
            /// Возвращает пустой элемент
            /// </summary>
            T getEmptyElement();

            /// <summary>
            /// Проверка что элемент является пустым
            /// </summary>
            bool checkEmptyElement(T element);
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace ShapeLibrary
{
    /// <summary>
    /// Абстрактный класс для фигур
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// набор параметров для фигуры - радиус, стороны и тд
        /// </summary>
        protected List<double> parametrs;

        /// <summary>
        /// нередактируемый набор параметров с проверкой
        /// </summary>
        protected ReadOnlyCollection<double> Parametrs
        {
            set
            {
                if (isExist(value.ToList()))
                {
                    parametrs = value.ToList();
                }
                else
                {
                    throw new ArgumentException("Parameters are not valid ");
                }
            }
            get
            {
                return parametrs.AsReadOnly();
            }
        }
        /// <summary>
        /// подсчет площади
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// проверка существования фигуры
        /// </summary>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        protected abstract bool isExist(List<double> parametrs);

    }
}

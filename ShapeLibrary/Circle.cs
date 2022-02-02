using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace ShapeLibrary
{
    /// <summary>
    /// класс для работы с кругом
    /// </summary>
    public class Circle : Shape
    {
        public Circle(double Radius)
        {
            Parametrs = new List<double>() { Radius }.AsReadOnly();
        }
        /// <summary>
        /// площадь круга
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI * Parametrs[0] * Parametrs[0];
        }
        /// <summary>
        /// проверка круга на существование
        /// </summary>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        protected override bool isExist(List<double> parametrs)
        {
            if (parametrs.Count == 1 && parametrs[0] > 0 && parametrs[0] <= double.MaxValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

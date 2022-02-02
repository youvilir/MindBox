using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ShapeLibrary
{
    /// <summary>
    ///  Класс для работы с треугольником
    /// </summary>
    public class Triangle : Shape
    {
        public Triangle(double aSide, double bSide, double cSide)
        {
            Parametrs = new List<double>() { aSide, bSide, cSide }.AsReadOnly();
        }
        /// <summary>
        /// подсчет площади треугольника по формуле Герона
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            // полупериметр
            double p = Parametrs.Sum() * 0.5;

            return Math.Sqrt(p * (p - Parametrs[0]) * (p - Parametrs[1]) * (p - Parametrs[2]));
        }
        /// <summary>
        /// проверка на существование треугольника 
        /// </summary>
        /// <param name="parametrs"></param>
        /// <returns></returns>
        protected override bool isExist(List<double> parametrs)
        {
            if (parametrs.Count == 3 && 
                parametrs[0] > 0  && 
                parametrs[1] > 0 && 
                parametrs[2] > 0 &&
                parametrs[0] <= double.MaxValue &&
                parametrs[1] <= double.MaxValue &&
                parametrs[2] <= double.MaxValue &&
                parametrs[0] < parametrs[1] + parametrs[2] &&
                parametrs[1] < parametrs[0] + parametrs[2] &&
                parametrs[2] < parametrs[0] + parametrs[1] )
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// проверка треугольника на прямоугольность
        /// </summary>
        /// <returns></returns>
        public bool isRigthTriangle()
        {
            var orderedParametrs = Parametrs.OrderBy(side => side).ToList();
            double hypotenuse = orderedParametrs[2];
            double firstCathetus = orderedParametrs[1];
            double secondCathetus = orderedParametrs[0];


            if (hypotenuse * hypotenuse == firstCathetus * firstCathetus + secondCathetus * secondCathetus)
            {
                return true;
            }
            else return false;
        }
    }
}

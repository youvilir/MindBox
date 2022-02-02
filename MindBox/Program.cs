using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeLibrary;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Triangle triangle = new Triangle(3,4,5);
                Console.WriteLine(triangle.Area());
                foreach (var item in triangle.Parametrs)
                {
                Console.WriteLine(item);

                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}

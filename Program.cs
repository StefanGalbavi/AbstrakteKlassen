using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 10);
            Circle circle = new Circle(3);

            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("Das Rechteck hat eine Fläche von: {0}", rectangle.GetArea());

            Console.WriteLine();

            Console.WriteLine(circle.ToString());
            Console.WriteLine("Das Kreis hat eine Fläche von: {0}", circle.GetArea());

            Console.ReadKey();
        }
    }
}

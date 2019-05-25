using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp222
{
    struct Point
    {
        public Int32 x;
        public Int32 y;
    };
        class Program
            
    {
        static void Main(string[] args)
        {
            Int32 N;
            Point p;
            Double dist = 0.00;
            Double maximum;
            List<Point> Poligon = new List<Point>();
            List<Double> P = new List<Double>();
            Console.Write("Vavedete broia na aglite na mnogoagalnika:");
            N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write("x=");
                p.x = int.Parse(Console.ReadLine());
                Console.Write("y=");
                p.y = int.Parse(Console.ReadLine());
                Poligon.Add(p);
            }
            for (int c = 0; c < N; c++)
            {
                for (int d = 0; d < N; d++)
                {

                    dist = Math.Sqrt(Math.Pow(Poligon[c].x - Poligon[d].x, 2) + Math.Pow(Poligon[c].y - Poligon[d].y, 2));
                    P.Add(dist);
                }
            }
            maximum = P[0];
            for (int count = 0; count < N; count++)
            {
                maximum = Math.Max(maximum, P[count]);
            }
            Console.Write(String.Format("Maksimalnia diametar v mnogoagalnika P e: {0:0.00}.", maximum));
            Console.ReadKey();
            Console.ReadLine();

        }
    }
}

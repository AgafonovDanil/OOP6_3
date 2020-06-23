using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tri triugOone = new Tri(2, 3, 4);
            triugOone.Display();
            Tri triugTwo = new Tri(12,1, 15);
            triugTwo.Display();
            Tri triugThree = new Tri(20, 21, 36);
            triugThree.Display();
            Console.ReadKey();
        }
    }
    class Tri

    {
        private bool Trig;
        private double A;
        private double B;
        private double C;

        public Tri(int l1, int l2, int l3)
        {
            double A = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);
            double B = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);
            double C = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);

            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
            {               
                Trig = true;
                A = A;
                B = B;
                C = C;

            }
            else
            {
                Trig = false;
            }
        }
        public void Display()
        {
            if (Trig == true)
            {
                Console.WriteLine(
                                  $"\nДанные треугольника\n\n" +
                                  $"A : {A.ToString("##.#")}" +
                                  $"\nB : {B.ToString("##.#")}" +
                                  $"\nC : {C.ToString("##.#")}");
            }
            else
                Console.WriteLine("\nТреугольник не построить");
        }
    }
   
}

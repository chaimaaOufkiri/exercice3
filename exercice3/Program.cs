using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            Point p1 = new Point();
            Point p2 = new Point();
            Point p3 = new Point();
            Console.WriteLine("Entrez l'abscisse de point 1 :");
            p1.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de point 1 :");
            p1.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'abscisse de  point 2 :");
            p2.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de  point 2:");
            p2.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'abscisse de  point 3 :");
            p3.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez l'ordonnee de  point 3");
            p3.y = int.Parse(Console.ReadLine());
            p.distance(p1, p2);
            p.egalite(p1, p2);
            p.translate(4);
            p.linearite(p1, p2, p3);
            Console.ReadLine();
        }
    }
}

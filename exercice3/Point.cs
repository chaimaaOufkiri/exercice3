using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
     class Point
    {
        public double x;            
       public double y;           

        public double getAbscisse()         
        {
            return x;
        }

        public void setAbscisse(double a)   
        {
            x = a;
        }

        public double getOrdonne()          
        {
            return y;
        }

        public void setOrdonne(double b)    
        {
            y= b;
        }
        public Point()
        {
        }
        public Point(double a, double b)   
        {
            x= a;
            y = b;
        }
        public void distance(Point p1,Point p2)
        {
            double x1, x2, y1, y2;
            x1 = p1.getAbscisse();
            x2 = p2.getAbscisse();
            y1 = p1.getOrdonne();
            y2 = p2.getOrdonne();
            double distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(distance);
        }
        public void egalite (Point p1, Point p2)
        {
            if ((p1.x == p2.x) && (p1.y == p2.y))
            {
                Console.WriteLine("vraie");
            }
            else
                Console.WriteLine("fausse");
        }
        public void translate(double v)
        {
            x = x + v;
            y = y + v;
        }

        public void linearite(Point p1,Point p2, Point p3)
        {
            double a, b;
            if (p1.x != p2.x) 
            {
                a = (p1.y - p2.y) / (p1.x - p2.x);
                b = p1.y + a * p1.x;
                if (a * p3.x + b == p3.y)
                {
                    Console.WriteLine("vraie");
                }
                else
                    Console.WriteLine("fausse");
            }
        }

    }
    
}


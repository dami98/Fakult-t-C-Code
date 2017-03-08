using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultät
{
    class Program
    {
        static void Main(string[] args)
        {
            //WurzelZiehen(289);
            //WurzelZiehenBis(20);
            //Rechner(); 
            //Fakultät(9);
            //RechenOperationen("*",3,1);
            //BerechnungKreis("umfang", 4);
            //BerechnungKreisQuadrat("umfang",5, 4);
            BerechnungDreieck(4, 3, 2);
            
            Console.WriteLine(Quad(3,3));

            Console.ReadLine();

        }

        private static void BerechnungDreieck(double a,double b,double c)
        {
            double h = 0;
            double wurzel1 = 0;
            if (a > b && a > c)
            {
                h = 2 * ((a * a) * (b * b) + (b * b) * (c * c) + (c * c) * (a * a)) - (Quad(a, 4) + Quad(b, 4) + Quad(c, 4));
                Console.WriteLine(WurzelZiehen(h)/(2*a));
                Console.WriteLine(h);
            }
        }



        public static double Quad(double a,int Anzahl)
        {
            double ergebnis = 1;

            for (int i = 1; i <= Anzahl; i++)
            {
                ergebnis = ergebnis * a;
            }


            return ergebnis;
        }



        private static void BerechnungKreisQuadrat(string p1,int p2, int p3)
        {
            double U = 0;
            string umfa = "UMFANG";
            string fläche = "FLÄCHE";
            if (p1.ToUpper() == umfa)
            {
                U =  p2 * 2 + p3 * 2;
                Console.WriteLine(U);
            }
            if (p1.ToUpper() == fläche)
            {
                U = p2 * p3;
                Console.WriteLine(U);
            }
        }


        private static void BerechnungKreis(string p1, int p2)
        {
            double U = 0;
            string umfa ="UMFANG";
            string fläche = "FLÄCHE";
            if (p1.ToUpper() == umfa)
            {
                U = 2 * 3.14 * p2;
                Console.WriteLine(U);
            }
            if (p1.ToUpper() == fläche)
            {
                U = 3.14 * (p2 * p2);
                Console.WriteLine(U);
            }

        }

        private static void RechenOperationen(string operat,int p1, int p2)
        {
            int ergebnis = 0;
            if (operat == "+")
            {
                ergebnis = p1 + p2;
            }else if (operat == "-")
            {
                ergebnis = p1 - p2;
            }else if (operat == "/")
            {
                ergebnis = p1 / p2;
            }else if (operat == "*")
            {
                ergebnis = p1 * p2;
            }
            Console.WriteLine(ergebnis);
        }

        private static void Fakultät(int p)
        {
            int ergebnis = 1;
            for (int i = 1; i <= p; i++)
            {
                ergebnis = ergebnis * i;
            }
            Console.WriteLine(ergebnis);
        }

        private static void Rechner()
        {
            Random rnd = new Random();
            Random rnd2 = new Random();


            var counter = 0;
            while (counter != 10)
            {
                var zahl1 = rnd.Next(1, 10);
                var zahl2 = rnd.Next(1, 10);
                Console.WriteLine("{0} * {1}", zahl1, zahl2);
                int ergebnis = Convert.ToInt32(Console.ReadLine());

                if (ergebnis == zahl1 * zahl2)
                {
                    Console.WriteLine("Richtig");
                    counter++;
                }
                else
                {
                    Console.WriteLine("Wrong");
                    counter = 0;
                }
            }            
        }

        private static double WurzelZiehenBis(double p)
        {
            double counter = -1;
            double ergebnis = 0;
            while (counter < p )
            {
                counter++;
                ergebnis = counter * counter;
                Console.WriteLine("Die Wurzel von: {0} \nist: {1}",ergebnis,counter);
                ergebnis = 0;
            }
            return ergebnis;
            
            
        }
        
        private static double WurzelZiehen(double p)
        {
            double counter=-1;
            double ergebnis= 0;
            while (ergebnis != p)
            {   
                counter++  ;
                ergebnis = counter * counter;
                if (counter > p / 2)
                {
                    Console.WriteLine("keine Wurzel");                    
                    return ergebnis;
                }             
            }
            Console.WriteLine(counter);
            return ergebnis;
        }


    }
}

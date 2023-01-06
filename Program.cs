using System;

namespace AverageNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
           Console.WriteLine("=============Bienvenido! :D===============");

           int valores, i, lim, suma = 0;
           double restas, cuadrados, prome, sumatoria = 0, varianza, desv;

           Console.Write("¿Cuántos números va a ingresar? ");
           lim = Convert.ToInt32(Console.ReadLine());

           for (i = 0; i <= lim-1; i++)
           {
                Console.WriteLine("Ingrese el número: ");
                valores = Convert.ToInt32(Console.ReadLine());
                suma = suma + valores;
           }

           prome = suma / lim;

           Console.WriteLine("La media es: ", prome);

           //restas
           for(i = 0; i <= lim-1; i++)
           {
                restas = valores - prome;
           }

           //cuadrados y sumatoria
           for(i = 0; i <= lim-1; i++)
           {
                cuadrados = restas * restas;
                sumatoria = sumatoria + cuadrados;
           }

           varianza = sumatoria / lim -1;
           desv =  Math.Sqrt(varianza);

           Console.WriteLine("Varianza es: ", varianza);
           Console.WriteLine("Desvicación estándar es: ", desv);
        }
    }
}
using System;

namespace clase_3
{
    class Program
    {
        static int Dividir(int dividendo, int divisor) {
            // Calculo el signo del divisor.
           int sign = ((dividendo < 0) ^ (divisor < 0)) ? -1 : 1;

            // Transformo el divisor y el dividendo en positivo.
            dividendo = Math.Abs(dividendo);
            divisor = Math.Abs(divisor);

            // Inicializo el contador.
            int cociente = 0;
            
            while (dividendo >= divisor) {
                dividendo -= divisor;
                ++cociente;
            }

            return sign * cociente;
        }
        static void Main(string[] args)
        {
            int dividendo = 25;
            int divisor = 2;
            Console.WriteLine("Resultado: " + Dividir(dividendo, divisor));
            Console.WriteLine("Resto: " + (dividendo - divisor * Dividir(dividendo, divisor)));   
        }
    }
}

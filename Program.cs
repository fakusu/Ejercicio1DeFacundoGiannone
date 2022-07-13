using System;

namespace Ejercicio1DeFacundoGiannone
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal dolar;
            decimal pesosoficial;
            decimal pesosparalelo;
            decimal euro;


            try
            {
                Console.WriteLine("Ingresar la cantidad de dolares con la quiere comprar pesos: ");
                dolar = Decimal.Parse(Console.ReadLine());
                pesosoficial = dolar * 230;
                Console.WriteLine($"Con esa cantidad de dolares puede comprar {pesosoficial} pesos");
                pesosparalelo = dolar * 280;
                euro = dolar * 1.17M;

                Console.WriteLine($"Con la misma cantidad de dolares, se pueden comprar {euro} euros y {pesosparalelo} pesos en el mercado paralelo.");
            }
            catch (Exception)
            {
                Console.WriteLine("Los valores ingresados no son validos.");
            }
            
        }
    }
}

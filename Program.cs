using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada1, entrada2;
            double numerador, denominador, resultado;

            Console.Beep();
            Console.WriteLine("---------");
            Console.Write("Digite um numerador: ");
            entrada1= Console.ReadLine();
            numerador= Convert.ToDouble(entrada1);
            Console.WriteLine();
            Console.Write("Digite um denominador: ");
            entrada2= Console.ReadLine();
            denominador= Convert.ToDouble(entrada2);
            Console.WriteLine("---------");

            resultado= numerador/denominador;

            if (denominador>0)
            {
                Console.WriteLine($"{numerador} dividido por {denominador} é igual a: {resultado}");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }
    }
}

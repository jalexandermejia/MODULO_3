using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSentenciaSwitch
{
    class Program
    {
        static void Main(string[] args)
        {


            int numero;
            Console.WriteLine("Digite el numero: ");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                Default:
                    Console.WriteLine("Fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}

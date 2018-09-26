using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero Maior");
            Console.WriteLine("-----------------");

            int n = 0;

            int intervalo = 0;

            int intervalo2 = 0;

            int i = 1;

            while (i <= 6)
            {
                Console.Write("Digite o " + i + "º numero: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n % 2 == 0)
                {
                    intervalo++;
                }
                if (n % 2 != 0)
                {
                    intervalo2++;
                }
                i++;
            }
            Console.WriteLine("Qtde de pares: " + intervalo);
            Console.WriteLine("Qtde de impares: " + intervalo2);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        /*Crear un programa que dibuje una escalera de números, donde cada línea de números comience en uno
     y termine en el número de la línea. Solicitar la altura de la escalera al usuario al comenzar. Ejemplo: si se
     ingresa el número 3:
     1
     12
      123*/
        {
            int numero;
            int escalera;
            Console.WriteLine("Ingrese la altura de la escalera de numeros");
            numero = int.Parse(Console.ReadLine());
            escalera = Escalera(numero);
            Console.ReadKey();
        }
        public static int Escalera (int numero)
        {
            int n1;
            int n2;
            for (n1 = 1; n1 <= numero; n1++)
            {
                for (n2 = 1; n2<n1; n2++)
                {
                    Console.Write(n2);
                }
                Console.WriteLine(n2);
            }
           
            return numero;
        }
    }
}

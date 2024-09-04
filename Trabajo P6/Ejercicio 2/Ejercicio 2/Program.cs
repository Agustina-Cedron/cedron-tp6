using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        /*Realizar una función que valide si un número es impar o no. Si es impar la función debe devolver un
verdadero, si no es impar debe devolver falso. Nota: la función no debe tener mensajes que digan si es
par o no.*/
        {
            int resultado;
            int numero;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            resultado = Resultado(numero);
            Console.ReadKey();
        }
        public static int Resultado(int numero)
        {


            if (numero % 2 == 1)
            {
                Console.WriteLine("verdadero");
            }
            else
            {
                Console.WriteLine("falso");
            }
            return numero;
        }
    }
}

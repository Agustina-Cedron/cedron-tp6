using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        /*Realizar un programa que pida al usuario una frase y una letra a buscar en esa frase. La función debe
devolver la cantidad de veces que encontró la letra. Nota: recordar el uso de la función Subcadena().*/
        {
            string frase;
            string inputLetra;
             Console.Write("Ingrese una frase: ");
            frase = Console.ReadLine();
             Console.Write("Ingrese una letra a buscar en la frase: ");
           inputLetra = Console.ReadLine();
           char letra = inputLetra[0];
        int cantidad = ContarLetra(frase, letra);
            Console.WriteLine("La letra {0} aparece {1} veces en la frase",letra,cantidad) ;
            Console.ReadKey();
    }

    static int ContarLetra(string frase, char letra)
    {
        int contador = 0;
        
        foreach (char c in frase)
        {
            if (c == letra)
            {
                contador++;
            }
        }
        
        return contador;
        }
    }
}

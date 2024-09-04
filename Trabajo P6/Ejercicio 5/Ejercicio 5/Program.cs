using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        /*Crea un procedimiento “convertirEspaciado”, que reciba como argumento un texto y muestra una
cadena con un espacio adicional tras cada letra. Por ejemplo, “Hola, epet5” devolverá “H o l a , e p e t 5
“. Crea un programa principal donde se use dicho procedimiento.*/
        {
            string texto;
            Console.WriteLine("Ingrese un texto");
            texto= Console.ReadLine();
            convertirEspaciado(texto);
            Console.ReadKey();
        }
        public static string convertirEspaciado(string texto)
        {
            char espaciado = ' ';
                foreach (var espacio in texto)
                {
                    Console.Write("{0}{1}",espacio,espaciado);
                   
                }
            
            return texto;
        }
        
    }
}

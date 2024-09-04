using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        /*Diseñar un procedimiento que reciba una frase, y el programa remueva todas las vocales . Al final el
procedimiento mostrará la frase final.
Por ejemplo:
Entrada: “Habia una vez un barco”
Salida: “Hb n vz n brc"*/
        {
            string frase;
            Console.WriteLine("Ingrese una frase");
            frase= Console.ReadLine();
            sinvocal(frase);
            Console.ReadKey();
        }
        public static void sinvocal(string frase)
        {
            string vocales = "aeiou";
           StringBuilder frasesinvocal=new StringBuilder();
            foreach (char letra in frase)
            {
                if (!vocales.Contains(letra))
                {
                    frasesinvocal.Append(letra);
                }
                
            }
            Console.WriteLine(frasesinvocal);

        }
    }
}

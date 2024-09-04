using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        /*Crear una función que calcule la suma de dos números. En el programa principal, solicitaremos al
usuario que ingrese los dos números para luego pasarlos como argumentos a la función. La función
realizará el cálculo de la suma y devolverá el resultado, que será mostrado para su visualización.*/
        {
            
            int n1;
            int n2;
            Console.WriteLine("Ingrese un numero");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2=int.Parse(Console.ReadLine());
            Resultado(n1, n2);
            Console.ReadKey();
        }
        public static int Resultado(int n1,int n2)
        {
            int suma;
            suma = n1 + n2;
            Console.WriteLine("La suma de {0} y {1} es: {2}", n1, n2, suma);
            return suma;
        }
        
    }
}

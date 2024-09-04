using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        /*Crear una función llamada “Login”, que recibe un nombre de usuario y una contraseña y que devuelve
Verdadero si el nombre de usuario es “usuario1” y si la contraseña es “epet5”. Además, la función
calculara el número de intentos que se ha usado para loguearse, tenemos solo 3 intentos, si nos
quedamos sin intentos la función devolverá Falso.*/
        {

            string usuario;
            string contrasenia;
            int cont = 0;
            bool band = false;
            Console.WriteLine("Bienvenido, por favor introduzca sus datos de acceso");
            while (band==false & cont<=2)
            {
                
                Console.WriteLine("Ingrese el nombre de usuario ");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese la contrasenia");
                contrasenia = Console.ReadLine();

                if(login(usuario,contrasenia))
                {
                    Console.WriteLine("Bienvenido al sistema");
                    band = true;
                    break;
                    
                }
                else 
                {
                    Console.WriteLine("Usuario o contrasenia incorrecta ");
                    cont++;
                }
                if (cont == 3)
                {
                    Console.WriteLine("Se han alcanzado los 3 intentos");
                }

            }
            
            Console.ReadKey();
        }
        public static bool login(string usuario, string contrasenia)
        {
            bool login1=true;
            string usuario1 = "usuario1";
            string contrasenia1 = "epetn5";



            if (usuario == usuario1 & contrasenia == contrasenia1)
            {
                login1 = true;
            }
            else
            {
                login1 = false;
            }

            return login1; 
        }
    }
}



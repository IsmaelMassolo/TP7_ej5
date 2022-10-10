/*Desarrolle un programa que permita calcular el FACTORIAL para un número entero
ingresado por el usuario. EL concepto de factorial para un numero N, es que se obtiene de
realizar la multiplicación de todos los números entre 1 y N.*/

using System;
using System.Threading;
namespace TP7_ej5
{       
    class Program
    {
        static void Main (string[] args)
        {
            string entrada ="";
            int numero = 0, factorial =1;
            long calculo =0;
            do
            {   
                titulos ();
                Console.WriteLine("Por favor digite un número entero\n");
                entrada = Console.ReadLine();
                numero = Convert.ToInt32(entrada);
                calculo =calculoFactorial (numero, factorial);
                titulos ();
                Console.WriteLine("El factorial de "+numero+" es: "+calculo+"\n");
                Console.WriteLine("Presione [C] para continuar u otro valor para salir");
                entrada = Console.ReadLine();
            }  
            while (entrada=="C" || entrada=="c");
            salidaDelPrograma ();
        }
        static void titulos ()
        {
            //Console.Clear();
            Console.WriteLine("C A L C U L O     D E     F A C T O R I A L\n");
        }
        static long calculoFactorial (int numero, int factorial)
        {
            for (int i = 1; i <= numero; i++)
                {   
                    factorial=i*factorial;
                }
            return factorial;
        }
        static void salidaDelPrograma ()
        {
            for (int i = 5; i >= 0; i--)
            {   
                titulos ();
                Console.WriteLine("Gracias por utilizar el servicio!");
                Console.WriteLine("saliendo -----> "+i);
                Thread.Sleep(600);
                Console.Clear();
            }
        }
    }
}
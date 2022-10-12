using System;

namespace Ej5__Factorial_Funcion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Magenta;
           
           

            Console.WriteLine("          ******* BIENBENIDO AL SISTEMA DE FACTORIALES *******"          );
            Console.WriteLine("LA FACTORIAL DEL NUMERO INGRESADO ES: {0}", factorial());
            Console.ReadKey();
            

           
            
            

        }

        
        static int factorial()
        {

            int acumulador, contador,fac ;
            acumulador=1;
            Console.WriteLine("INGRESE EL NUMERO DEL CUAL QUIERE CALCULAR LA FACTORIAL");
            fac= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            for (contador =1; contador <= fac; contador++)
            {
                acumulador = acumulador * contador;
            }
            return acumulador;
        }

        



    }
}

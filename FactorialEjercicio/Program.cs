using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialEjercicio
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int op;
            string num;
            do{
                Console.WriteLine("1-hacer el factorial\n2-Salir");
                op=int.Parse(Console.ReadLine());
                if(op==1){
                    Console.WriteLine("Ingresa el numero");
                    num = Console.ReadLine();
                    if (valida(num))
                    {
                        Console.WriteLine(factorial(int.Parse(num)));

                    }
                    else
                    {
                        Console.WriteLine("No es una opcion valida");
                    }
                }
            }while(op!=2);
        }


        public static int factorial(int n)
        {
            if (n == 1)

                return 1;

            return n * factorial(n - 1); 

        }
        public static bool valida(string cadena)
        {
            try
            {
            int val = int.Parse(cadena);
            return true;
        }
            catch(Exception exe){
                return false;
            }
        }

    }
}

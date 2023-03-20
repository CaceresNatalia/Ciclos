using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
           //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar
           //por pantalla cuántos de esos números son primos.

            int n, primos=0;

            for (int x = 0; x < 3; x++){
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                int cont=0;
                
                    for (int y = 1; y <= n; y++){

                            if (n%y==0)
                                cont++;
                    
                    }

                if (cont==2)
                   primos++;
                    

            }

                

            Console.WriteLine("La cantidad de nros primos es de " + primos);


        }
    }
}

using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla
            //el máximo de los números pares y el mínimo de los números impares.

            int n, maxP=0, minIm=0;

            for (int x= 0; x < 6; x++){
                Console.WriteLine("Ingrese un nro: ");
                n = int.Parse(Console.ReadLine());

                if (n%2==0){
                    if (n>maxP)
                        maxP = n;
                }else if(minIm==0)
                        minIm=n;
                        else if(n<minIm)
                                minIm = n;
                }
                
            
            Console.WriteLine("El máximo de los pares es " + maxP +" y el mínimo de los impares es " + minIm);
        }
    }
}

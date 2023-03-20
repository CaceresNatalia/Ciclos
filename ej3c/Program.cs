using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas 
            //entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos
            //números tiene cada lista.

            int n;

            Console.WriteLine("Ingrese un nro:");
            n = int.Parse(Console.ReadLine());

            while(n>0){
                int cont=0;

                while(n!=0){
                    cont++;

                    Console.WriteLine("Ingrese un nro:");
                    n = int.Parse(Console.ReadLine());

                }

                Console.WriteLine("La lista tuvo " + cont + " números.");

                Console.WriteLine("Ingrese un nro:");
                n = int.Parse(Console.ReadLine());

            }

        }
    }
}

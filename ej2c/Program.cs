using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
            //Se pide determinar e informar:

            //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, mayImp=0, porcentaje=0, mayGr=0, mayMen=0;

            for (int x = 0; x < 5; x++){

                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                int impar = 0, cont= 0, m=0;
                bool ord = true;

                while (n!=0){
                    cont++;
                    if (n%2!=0)
                        impar++;

                    if(m==0){
                        m=n;
                    }else{
                        if (m>n)
                            m=n;
                        else
                            ord=false;
                    }


                    Console.WriteLine("Ingrese de nuevo un número: ");
                    n = int.Parse(Console.ReadLine());
                    
                }
                porcentaje = (impar*100)/cont;

                if (mayImp==0){
                    mayImp = porcentaje;
                    mayGr = x+1;
                } else {
                    if(porcentaje>mayImp){
                        mayImp = porcentaje;
                        mayGr = x+1;
                    }
                }

                if (ord)
                    mayMen++;
                }
                Console.WriteLine("El grupo con mayor porcentaje de impares es el " + mayGr + " y el porcentaje es de " + mayImp + "%");
                Console.WriteLine(mayMen + " grupos están ordenados de mayor a menor");

        }
    }
}

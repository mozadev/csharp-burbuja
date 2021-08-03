using System;
using System.Collections;

namespace metodoBurbuja
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arreglo = new int[10];
            ingresaDatosArreglo(arreglo);
            Console.WriteLine("Ordenamiento Burbuja");
            ordenamientoBurbuja(arreglo);
            

        }


        static void ingresaDatosArreglo(int[] arreglo)
        {

            for (int i = 0; i < arreglo.Length; i++)
            {
                int numero;
                Console.Write("ingrese el numero" + i + ": ");
                numero = int.Parse(Console.ReadLine());
                arreglo[i] = numero;
            }

        }

        static void ordenamientoBurbuja(int[] arreglo)
        {
            int temp;  //[3,4,5]
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {       // 3    <  4
                    if (arreglo[i] < arreglo[j])
                    {     // 4        3
                        temp = arreglo[i];
                        arreglo[i] = arreglo[j];
                        arreglo[j] = temp;
                    }

                }

            }

            foreach (var item in arreglo)
            {
                Console.Write(item+" ");
               // Console.WriteLine(' ');
            }
            Console.WriteLine();
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]+" ");
            }

        }

    }
}
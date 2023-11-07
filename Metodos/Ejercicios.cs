using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion.Metodos
{
    public class Ejercicios
    {
        public void eje1()
        {
            int[,] matrizProductos = new int[,] {
            {500, 3000, 100, 400, 4000},
            {1000, 150, 200, 500, 1850},
            {250, 1800, 2900, 300, 5250},
            {400, 130, 90, 2400, 3020},
            {60, 20, 4000, 3600, 7680}
        };
            
            int[] sumaPorVendedor = new int[matrizProductos.GetLength(1)];

      
            int sumaTotal = 0;
            for (int i = 0; i < matrizProductos.GetLength(0); i++)
            {
                for (int j = 0; j < matrizProductos.GetLength(1); j++)
                {
                    sumaPorVendedor[j] += matrizProductos[i, j];
                    sumaTotal += matrizProductos[i, j];
                }
            }

            Console.WriteLine("Total X Vendedor");
            for (int i = 0; i < sumaPorVendedor.Length; i++)
            {
                Console.Write(sumaPorVendedor[i] + "\t");
            }

            Console.WriteLine("\n\nSuma Total: " + sumaTotal);

            Console.WriteLine("Total X Vendedor");
            Console.WriteLine("-------------------------");
            Console.WriteLine("| Vendedor | Suma Total |");
            Console.WriteLine("|----------|------------|");
            for (int i = 0; i < sumaPorVendedor.Length; i++)
            {
                Console.WriteLine($"|   {i + 1}      |   {sumaPorVendedor[i],-8} |");
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("\nSuma Total: " + sumaTotal);

            Console.ReadKey();
        }
    }

    
    public class Ejercicio2
    {
            public void Curp()
            {
                Console.WriteLine("Ingrese el CURP:");
                string curp = Console.ReadLine().ToUpper();

                if (curp.Length != 10)
                {
                    Console.WriteLine("La longitud del CURP no es válida.");
                    return;
                }

                char[] curpArray = curp.ToCharArray();

                char[] fechaNacimiento = new char[6];
                char sexo = curpArray[10];


                Array.Copy(curpArray, 8, fechaNacimiento, 0, 6);

                string año = new string(fechaNacimiento, 0, 2);
                string mes = new string(fechaNacimiento, 2, 2);
                string dia = new string(fechaNacimiento, 4, 2);


                string mensajeSexo = (sexo == 'H') ? "masculino" : (sexo == 'M') ? "femenino" : "desconocido";


                Console.WriteLine($"Usted es de sexo {mensajeSexo} y su fecha de nacimiento es {dia}/{mes}/{año}.");
            }
        

    }
    public class Ejercicio3
    {

        public void Calificaciones()
        {
            int[] calificaciones = new int[10];
            Random random = new Random();

           
            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = random.Next(0, 101); 
            }

            Console.WriteLine("Matriz desordenada:");
            ImprimirMatriz(calificaciones);

            OrdenamientoBurbujaDescendente(calificaciones);
            Console.WriteLine("\nMatriz ordenada de forma descendente:");
            ImprimirMatriz(calificaciones);

            int numeroBuscado = 75;
            int posicion = BusquedaLineal(calificaciones, numeroBuscado);

         
            if (posicion != -1)
            {
                Console.WriteLine($"\nEl número 75 se encuentra en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine("\nEl número 75 no se encuentra en la matriz ordenada.");
            }
        }

        static void ImprimirMatriz(int[] matriz)
        {
            foreach (int numero in matriz)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        static void OrdenamientoBurbujaDescendente(int[] matriz)
        {
            int n = matriz.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (matriz[j] < matriz[j + 1])
                    {
                    
                        int temp = matriz[j];
                        matriz[j] = matriz[j + 1];
                        matriz[j + 1] = temp;
                    }
                }
            }
        }

        static int BusquedaLineal(int[] matriz, int objetivo)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] == objetivo)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }



}





































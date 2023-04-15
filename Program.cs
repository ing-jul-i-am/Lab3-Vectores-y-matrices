using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Vectores_y_matrices
{
    internal class Program
    {
        public string[] abc = new string[26];

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL\n");
            Console.WriteLine("1. Vector en un abecedario");
            Console.WriteLine("2. Matriz de promedio de notas");
            Console.WriteLine("3. Vector de números pares e impares");
            Console.WriteLine("4. Matriz de 5 por 5");
            Console.WriteLine("5. Tablas de multiplicar");
            Console.WriteLine("0. Salir");
            Console.WriteLine("\nEscoga la opcion que necesita: \n");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 0:
                    Console.WriteLine("\nDesarrollado por Julian Barrera.");
                    Console.ReadKey();
                    break;

                case 1:
                    Abecedario();
                    Menu();
                    break;

                case 2:
                    Promedio();
                    Menu();
                    break;

                case 3:
                    ParesImpares();
                    Menu();
                    break;

                case 4:
                    Matriz5X5();
                    Menu();
                    break;

                case 5:
                    TablasDeMultiplicar();
                    Menu();
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta. Vuelve a intentarlo.");
                    Console.ReadKey();
                    Menu();
                    break;
            }
        }

        static void Abecedario()
        {
            Console.Clear();
            Console.WriteLine("Abecedario en un vector");
            Console.WriteLine("Presione cualquier tecla para guardar el abecedario en un vector.");
            Console.ReadKey();

            string[] abecedario = new string[26];
            int dato = 0;
            for (int i = 0; i < 26; i++)
            {
                dato = 65 + i;
                abecedario[i] = Convert.ToString((char)dato);
            }

            Console.WriteLine("Listo! Presione cualquier tecla para ver el vector.");
            Console.ReadKey();

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine("\n" + abecedario[i]);
            }
            Console.ReadKey();
        }

        static void Promedio()
        {
            Console.Clear();
            Console.WriteLine("PROMEDIO DE NOTAS");

            double temporal = 0;
            //[filas, columnas]
            double[,] notas = new double[4, 5];

            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine($"\nIngrese las notas del curso {c + 1}\n");
                for (int f = 0; f < 4; f++)
                {
                    Console.WriteLine($"Nota {f + 1}: ");
                    notas[f, c] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("\n");
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 4; f++)
                {
                    temporal += notas[f, c];
                }
                Console.WriteLine($"El promedio de curso {c+1} es {temporal/4}.\n");
                temporal = 0;
            }

            Console.WriteLine("\nPresione cualquier tecla para regresar al menu principal.");
            Console.ReadKey();

        }

        static void ParesImpares()
        {
            Console.Clear();
            Console.WriteLine("NUMEROS PARES E IMPARES");
            Console.WriteLine("Se clasificaran en 2 vectores los numeros pares e impares del 1 al 100.");
            Console.WriteLine("Presione cualquier tecla para ejecutar.");
            Console.ReadKey();

            int[] pares = new int[50];
            int contadorPar=0, contadorImpar=0;
            int[] impares = new int[50];

            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    //i es par
                    pares[contadorPar] = i;
                    contadorPar++;
                } else
                {
                    //i es impar
                    impares[contadorImpar] = i;
                    contadorImpar++;
                }
            }

            Console.WriteLine("Par  --  Impar");
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"{pares[i]}   --   {impares[i]}");
            }
            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();

        }

        static void Matriz5X5()
        {
            Console.Clear();
            Console.WriteLine("MATRIZ DE 5x5");
            int[,] m = new int[5, 5];
            int[] filas = new int[5], columnas = new int[5];

            Console.WriteLine("Ingrese los valores segun corresponda la posicion Fila*Columna.");
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine($"Valor [{f+1},{c+1}]: ");
                    m[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    filas[f] += m[f, c];
                }
            }

            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 5; f++)
                {
                    columnas[c] += m[f, c];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Total Fila {i+1}: {filas[i]}");
            }

            Console.WriteLine("\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Total columna {i + 1}: {columnas[i]}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void TablasDeMultiplicar()
        {
            Console.Clear();
            Console.WriteLine("TABLAS DE MULTIPLICAR");
            Console.WriteLine("Se creara una matriz 10*10 con los resultados de las tablas de multiplicar.");
            Console.WriteLine("Cada celda contendra el resultado de la operacion #fila*#columna.");
            Console.WriteLine("Presione cualquier tecla para comenzar.\n");

            int[,] m = new int[10,10];
            string resultado = "";

            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    m[f, c] = (f + 1) * (c + 1);
                }
            }

            for (int f = 0; f < 10; f++)
            {
                resultado = "\n";
                for (int c = 0; c < 10; c++)
                {
                    resultado += m[f, c] + ", ";
                }
                Console.WriteLine(resultado);
                resultado = "";
            }

            Console.WriteLine("\nPresione cualquier tecla para regresar al menu.");
            Console.ReadKey();
        }
    }
}

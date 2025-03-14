using System;
using System.Collections.Generic;
namespace practicaFinalProgramacion
{
    struct nombreEstructura 
    {
        public int fila1;
        public int fila2;
        public int fila3;
        public int fila4;

        public nombreEstructura(int fila1, int fila2, int fila3, int fila4)
        {
            this.fila1 = fila1;
            this.fila2 = fila2;
            this.fila3 = fila3;
            this.fila4 = fila4;
        }
    }
    internal class Program
    {
        static List<nombreEstructura> datosConvertidos = new List<nombreEstructura>();
        
        static string[] columnas = new string[6]; //Columnas - Pilotos F1 

        static string[] filas = { "Sakhir", "Jeddah", "Albert Park", "Suzuka" }; //filas - Circuitos F1

        static int[,] matriz = new int[4,6]; //4 filas, 6 columnas

        static bool arregloCargado, listaCargada, matrizCargada = false;
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1. Cargar pilotos en arreglo");
                Console.WriteLine("2. Mostrar pilotos ordenados alfabeticamente");
                Console.WriteLine("3. Ingresar puntos obtenidos en cada circuito en una matriz");
                Console.WriteLine("4. Mostrar matriz de puntos obtenidos por cada piloto");
                Console.WriteLine("5. Convertir matriz a lista dinamica");
                Console.WriteLine("6. Calcular y mostrar promedio de puntos de lista");
                Console.WriteLine("0. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion) 
                {
                    case 0:
                        Console.WriteLine("Saliendo");
                        break;
                    case 1:
                        cargarElementos();
                        break;
                    case 2:
                        ordenarElementos();
                        mostrarElementos();
                        break;
                    case 3:
                        cargarMatriz();
                        break;
                    case 4:
                        mostrarMatriz();
                        break;
                    case 5:
                        convertirEnLista();
                        break;
                    case 6:
                        calcularPromedios();
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta vuelva a ingresar otra opcion");
                        break;
                }
            }
            while (opcion != 0);
        }

        static void cargarElementos()
        {
            for (int i = 0; i < columnas.Length; i++) 
            {
                Console.Write($"Ingrese nombre de piloto:");
                do
                {
                    columnas[i] = Console.ReadLine();
                    if (columnas[i] == "") 
                    {
                        Console.WriteLine("Error, no puede estar vacio el elemento. Vuelva a ingresar!");
                    }
                }
                while (columnas[i] == "");
            }
            arregloCargado = true;
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();
        }

        static void ordenarElementos() 
        {
            for (int i = 0; i < columnas.Length - 1; i++)
            {
                for (int j = 0; j < columnas.Length - i - 1; j++)
                {
                    if (string.Compare(columnas[j], columnas[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        string temp = columnas[j];
                        columnas[j] = columnas[j + 1];
                        columnas[j + 1] = temp;
                    }
                }
            }         
        }

        static void mostrarElementos() 
        {
            if (arregloCargado)
            {
                foreach (var columna in columnas)
                {
                    Console.WriteLine(columna);
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else 
            {
                Console.WriteLine("Error, arreglo vacio. Ingrese datos!");
            }
        }

        static void cargarMatriz() 
        {
            if (arregloCargado)
            {
                for (int i = 0; i < filas.Length; i++)
                {
                    Console.WriteLine($"Puntos obtenidos en {filas[i]}");
                    for (int j = 0; j < columnas.Length; j++)
                    {

                        while (true)
                        {
                            Console.Write($"{columnas[j]} : ");
                            if (int.TryParse(Console.ReadLine(), out int valor))
                            {
                                matriz[i, j] = valor;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Entrada inválida. Debe ser un número. Intente nuevamente.");
                            }
                        }
                    }
                }
                matrizCargada = true;
            }
            else 
            {
                Console.WriteLine("Debe ingresar primero el arreglo");
            }

        }

        static void mostrarMatriz() 
        {
            if (matrizCargada) 
            {
                for (int i = 0; i < filas.Length; i++)
                {
                    Console.Write(filas[i]);
                    for (int j = 0; j < columnas.Length; j++)
                    {
                        Console.Write($"{matriz[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            else 
            {
                Console.WriteLine("Error. Debe cargar primero la matriz");
            }

        }

        //Convertir datos a una lista dinamica
        static void convertirEnLista() 
        {
            if (matrizCargada) 
            {
                for (int i = 0; i < filas.Length; i++)
                {
                    datosConvertidos.Add(new nombreEstructura(matriz[i, 1], matriz[i, 2], matriz[i, 3], matriz[i, 4]));
                }
                listaCargada = true;
                Console.WriteLine("Datos convertidos a lista dinamica");
            }
            else 
            {
                Console.WriteLine("Error. Debe cargar primero la matriz");
            }

        }

        static void calcularPromedios() 
        {
            double promedio;
            if (listaCargada)
            {
                for (int i = 0; i < filas.Length; i++)
                {
                    int suma = 0;
                    for (int j = 0; j < columnas.Length; j++)
                    {
                        suma += matriz[i, j];
                    }
                    promedio = suma / columnas.Length; 
                    Console.WriteLine($"El promedio es: {promedio}");
                }
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Error. Debe convertir la matriz a lista primero.");
            }
        }

    }
}

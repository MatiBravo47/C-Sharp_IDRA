using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Guia5Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1.
             * Desarrolla 3 funciones sin argumentos.
             * Funcion 1: Debe devolver un msj de bienvenida
             * Funcion 2: Solicitar nombre y edad
             * Funcion 3: Llamar a funcion 1 y funcion 2. Mostrar 
             * bienvenida y datos del cliente.
            */
            string nombre;
            int edad;

            void Bienvenida() 
            {
                Console.WriteLine("Bienvenido al sistema de gestion de clientes.");
            }

            void PedirDatos()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
            }

            void ImprimirBienvenidaDatos()
            {
                PedirDatos();
                Console.Clear(); //Limpia consola
                Bienvenida();
                Console.WriteLine("Nombre: " + nombre );
                Console.WriteLine("Edad: " + edad);
            }
            
            ImprimirBienvenidaDatos();
            Console.ReadLine();
            /*
             * 2. Desarrolle un programa que realice lo siguiente:
             * - Pida al usuario que ingrese numeros de un digito(0-9) repetidamente
             * - El bucle de entrada de continuar hasta que ingrese la letra N.
             * - Por cada numero ingresado, el programa debe llamar a una funcion 
             * que reciba el numero como parametro y devuelva su cuadrado. 
             * - El programa debe imprimir el numero originar y su cuadrado despues 
             * de cada entrada valida.
            */
            string opcion;
            int numero; 

            int CalcularCuadrado(int numEntero)
            {
                return numEntero * numEntero;
            }
            
            //Metodo principal
            Console.WriteLine("Ingrese un numero de un digito (0-9) o 'N' para salir");
            opcion = Console.ReadLine();
            while (opcion != "N")
            {
                numero = int.Parse(opcion);
                Console.WriteLine($"{numero} al cuadrado es {CalcularCuadrado(numero)}" );
                Console.WriteLine("Ingrese un numero de un digito (0-9) o 'N' para salir");
                opcion = Console.ReadLine();
            }
            /*
             * 3.
             * Practica: Sin argumentos ni return en los metodos
             * Primer metodo: 
             * - nombre: Mostrar Bienvenida
             * - Debe imprimir un mensaje de bienvenida
             * Segundo metodo:
             * - Nombre: Mostrar instrucciones
             * - Debe imprimir instrucciones lavarse las manos.
            */
            void MostrarBienvenida()
            {
                Console.WriteLine("Bienvenido al programa.");
            }

            void MostrarInstrucciones() 
            {
                Console.WriteLine("1. Moje sus manos con agua limpia y corriente (tibia o fría), cierre el grifo y aplique jabón.");
                Console.WriteLine("2. Enjabone las manos frotando con el jabón. Enjabone la parte posterior de las manos, entre los dedos y debajo de las uñas.");
                Console.WriteLine("3. Frote sus manos durante al menos 20 segundos.");
                Console.WriteLine("4. Enjuague sus manos bien bajo agua limpia y corriente.");
                Console.WriteLine("5. Seque sus manos con una toalla limpia o séquelas al aire.");
            }

            MostrarBienvenida();
            MostrarInstrucciones();
            Console.ReadLine();
            /*
             * 4. Saludo y nombre 
             * Programa que incluya dos metodos. Uno de ellos debe aceptar un parametro, pero no debe retornar un valor.
             * -Primer metodo: 
             * Nombre: MostrarSaludo 
             * Parametro: String nombre
             * Debe imprimir un saludo personalizado
             *- Segundo metodo:
             * Nombre: SolicitudNombre
             * Debe solicitar al usuario que ingrese un nombre y llamar al metodo MostrarSaludo.
            */
            string nombre;
            void MostrarSaludo(string nombreSaludo)
            {
                Console.WriteLine($"Hola {nombreSaludo}!"  );
            }

            void SolicitarNombre()
            {
                Console.WriteLine("Ingrese un nombre");
                nombre = Console.ReadLine();
                MostrarSaludo(nombre);
            }
            SolicitarNombre();
            Console.ReadLine();
            /*
             * 5. Realizar 10 sumas y productos
             * 
            */
            void CalcularSuma(int a, int b, int c)
            {
                Console.WriteLine("La suma de los numeros es: "+ (a + b + c));
            }

            void CalcularProducto(int a, int b, int c)
            {
                Console.WriteLine("El producto de los numeros es: " + (a * b * c));
            }

            void SolicitarNumeros() 
            {
                int a, b, c;
                Console.Write("Ingrese valor 1: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese valor 2: ");
                b = int.Parse(Console.ReadLine());
                Console.Write("Ingrese valor 3: ");
                c = int.Parse(Console.ReadLine());
                CalcularSuma(a, b, c);
                CalcularProducto(a, b, c);
            }
            for (int i = 0; i<= 10; i++ )
            {
                SolicitarNumeros();
            }
            Console.ReadLine();
            /*
             * 6.
            */
            double CalcularAreaCirculo(double radio)
            {
                return Math.PI * radio * radio;
            }

            double CalcularAreaRectangulo(double largo, double ancho)
            {
                return largo * ancho;
            }

            void SolicitarDatosYMostrarResultados()
            {
                double radioIngresado, largoIngresado, anchoIngresado;

                Console.Write("Ingrese el radio del circulo: ");
                radioIngresado = double.Parse(Console.ReadLine());
                Console.WriteLine("El area del circulo es: " + CalcularAreaCirculo(radioIngresado));
                
                Console.Write("Ingrese el largo del rectangulo: ");
                largoIngresado = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el ancho del rectangulo: ");
                anchoIngresado = double.Parse(Console.ReadLine());
                Console.WriteLine("El area del circulo es: " + CalcularAreaRectangulo(largoIngresado, anchoIngresado));
            }
            char opcion = 'S'; 
            while (opcion == 'S')
            { 
                SolicitarDatosYMostrarResultados();
                Console.WriteLine("Desea realizar otro calculo?(S/N)");
                opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.ReadLine();
            /*
             * 7.
            */
            int LeerNumero()
            {
                Console.WriteLine("Ingrese un numero");
                return int.Parse(Console.ReadLine());     
            }

            bool EsPar(int numero)
            {
                return numero % 2 == 0;
            }

            int CalcularCuadrado(int numero) 
            {
                return numero*numero;
            }

            int CalcularCubo(int numero) 
            {
                return numero*numero*numero;
            }

            void MostrarResultados() 
            {
                int numero;
                numero = LeerNumero();
                
                if (EsPar (numero))
                {
                    Console.WriteLine($"El numero {numero} es par");
                }
                else
                { 
                    Console.WriteLine($"El numero {numero} es impar");
                }

                Console.WriteLine($"El cuadrado de {numero} es " + CalcularCuadrado(numero));
                Console.WriteLine($"El cubo de {numero} es " + CalcularCubo(numero));
            }
            MostrarResultados();
            Console.ReadLine();
            /*
             * 8.
            */

            int Sumar(int a, int b)
            {
                return a + b;
            }

            int Restar(int a, int b)
            {
                return a - b;
            }

            int Multiplicar(int a, int b)
            {
                return a * b;
            }

            double Dividir(int a, int b)
            {
                return a / b;
            }
            
            int ElegirOperacion() 
            {
                Console.WriteLine("Seleccione una operacion");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                return int.Parse(Console.ReadLine());
            }

            int IngresarNumero() 
            {
                Console.WriteLine("Ingrese un numero entero");
                return int.Parse(Console.ReadLine());
            }

            int numero1, numero2, opcion;
            char respuesta = 'S';
            while (respuesta == 'S')
            {
                numero1 = IngresarNumero();
                numero2 = IngresarNumero();
                opcion = ElegirOperacion();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El resultado de la suma es: " + Sumar(numero1, numero2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado de la resta es: " + Restar(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado de la multiplicacion es: " + Multiplicar(numero1, numero2));
                        break;
                    case 4:
                        Console.WriteLine("El resultado de la division es: " + Dividir(numero1, numero2));
                        break;
                }
                Console.WriteLine("Desea hacer otro calculo? (S/N)");
                respuesta = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}

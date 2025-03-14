using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Guia3P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Calculadora basica:
             * Objetivo: Crear una calculadora simple que pueda sumar, restar, multiplicar o dividir dos numeros.
             * Producto esperado: Un programa que solicita al usuario dos numeros y una operacion, luego muestra el 
             * resultado de la operacion.
            */
            /*
            Console.WriteLine("Ingrese el primer numero:");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Elige la operacion:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Producto");
            Console.WriteLine("4. Division");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"La suma es: {numero1 + numero2}");
                    break;
                case 2:
                    Console.WriteLine($"La resta es: {numero1 - numero2}");
                    break;
                case 3:
                    Console.WriteLine($"El producto es: {numero1 * numero2}");
                    break;
                case 4:
                    if (numero2 != 0)
                    {
                        Console.WriteLine($"La division es: {numero1 / numero2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;    
            }

            Console.ReadLine();            
        */
            /*
             * Dias de la semana:
             * Objetivo: Desarrollar un programa que, dado un numero del 1 al 7,
             * muestre el dia correspondiente de la semana.
             * Producto esperado: Un programa que solicita al usuario un numero del 1 al 7 
             * y muestra el dia de la semana correspondiente.
            */
            /*
            int numeroDia;
            Console.WriteLine("Ingrese un numero del 1 al 7");
            numeroDia = int.Parse(Console.ReadLine());

            switch (numeroDia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Numero incorrecto");
                    break;
            }
            Console.ReadLine();
            */
            /*
             * Conversion de califaciones a letras:
             * Objetivo: Escribir un programa que tome una calificacion numerica
             * y la convierta a una letra segun una escala predefinida.
             * Producto esperado: Un programa que solicita al usuario una calificacion 
             * numerica y muestra la calificacion en letra.
            */
            /*
            int nota1;
            Console.WriteLine("Ingrese calificacion");
            nota1 = int.Parse(Console.ReadLine());
            
            switch (nota1)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("D");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("C");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("B");
                    break;
                case 9:
                case 10:
                    Console.WriteLine("A");
                    break;
                default:
                    Console.WriteLine("Ingresaste una calificacion incorrecta");
                    break;
            }
        Console.ReadLine();
        */
            /*
             *Clasificacion de triangulos
             *Objetivo: Crear un programa que determine si un triangulo es equilatero,
             *isosceles o escaleno, dados los valores de sus tres lados.
            */
            /*
             * Estaciones del anio:
             * Objetivos: Desarrollar un programa que, dado un numero de mes
             * identifique la estacion del anio correspondiente.
             * Producto esperado: Un programa que solicita al usuario un numero 
             * de mes y muestra la estacion del anio correspondiente.
            */
            /*
            int numeroMes;
            Console.WriteLine("Ingrese un mes");
            numeroMes = int.Parse(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Verano");
                    break;
                case 4: 
                case 5:
                case 6:
                    Console.WriteLine("Otonio");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Invierno");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Primavera");
                    break;
            }
            Console.ReadLine();
        */
            /*
             * Dias en un mes:
             * Objetivo: Escribir un programa que, dado un numero de mes, determine
             * la cantidad de dias que tiene ese mes.
             * Producto esperado: Un programa que solicita al usuario un numero de mes
             * y muestra la cantidad de dias que tiene ese mes.
            */
            int numeroMes;
            Console.WriteLine("Ingrese numero de mes");
            numeroMes = int.Parse(Console.ReadLine());

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("31");
                    break;
                case 2:
                    Console.WriteLine("28");
                    break;
                case 3:
                    Console.WriteLine("31");
                    break;
                case 4:
                    Console.WriteLine("30");
                    break;
                case 5:
                    Console.WriteLine("31");
                    break;
                case 6:
                    Console.WriteLine("30");
                    break;
                case 7:
                case 8:
                    Console.WriteLine("31");
                    break;
                case 9:
                    Console.WriteLine("30");
                    break;
                case 10:
                    Console.WriteLine("31");
                    break;
                case 11:
                    Console.WriteLine("30");
                    break;
                case 12:
                    Console.WriteLine("31");
                    break;
                default:
                    Console.WriteLine("Numero de mes incorrecto");
                    break;
            }
        Console.ReadLine();
        }

    }
}

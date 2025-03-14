using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Guia4Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Sumar Numeros 
             * Objetivo: El programa debe permitir al usuario ingresar numeros enteros uno por uno
             * y sumar dichos numeros hasta que el usuario decida detenerse.
            */
            int valor, suma = 0;
            do
            {
                Console.WriteLine("Ingrese un numero en entero(0 para finalizar)");
                valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
            }
            while (valor != 0);
            Console.WriteLine($"La suma de los valores es: {suma}");
            /*
             * 2. Contar hasta un numero  
             * Objetivo: El programa debe solicitar al usuario un numero limite y luego contar 
             * desde 0 hasta ese numero, mostrando cada numero en la consola.
            */
            int limite, contador = 0;
            Console.WriteLine("Ingrese un numero limite");
            limite = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= limite);
            /*
             * 3.Convertir temperaturas 
             * Objetivo: El programa debe convertir las temperaturas de Celsius a Fahrenheit y permitir
             * al usuario realizar multiples conversiones hasta que decida deternerse.
            */
            double celsius, fahrenheit;
            int contador = 1;
            char respuesta;
            do
            {
                Console.WriteLine("Ingrese temperatura(-1 para cancelar)");
                celsius = double.Parse(Console.ReadLine());
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{fahrenheit}");
            }
            while (celsius != -1);
            /*
             * 4. Contador de vocales 
             * Objetivo: El programa debe contar el numero de vocales en un texto ingresado por el usuario
             * y permitirle repetir el proceso con diferentes textos.
            */
            string cadena;
            Console.WriteLine("Ingrese texto");
            cadena = Console.ReadLine();
            int i = 0, cantVocales = 0;
            do
            {
                if (cadena[i] == 'a' || cadena[i] == 'e' || cadena[i] == 'i' || cadena[i] == 'o' || cadena[i] == 'u') 
                {
                    cantVocales++;
                }
                i++;
            }
            while (i < cadena.Length);
            Console.WriteLine($"Cantidad de vocales: {cantVocales}");
            /*
             * 5. Calculadora basica
             * Objetivo: el programa debe realizar operaciones aritmeticas basicas(suma, resta, multiplicacion y division)
             * entre dos numeros ingresados por el usuario y permitirle realizar multiples calculos.
            */
            int opcion;
            double valor1, valor2;
            char continuar;
            do
            {
                
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese valor 1");
                valor1 = double.Parse(Console.ReadLine()); 
                Console.WriteLine("Ingrese valor 2");
                valor2 = double.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Console.WriteLine($"Resultado: {valor1 + valor2}");
                    break;
                    case 2: Console.WriteLine($"Resultado: {valor1 - valor2}");
                    break;
                    case 3: Console.WriteLine($"Resultado: {valor1 * valor2}");
                    break;
                    case 4: Console.WriteLine($"Resultado: {valor1 / valor2}");
                    break;
                }
                Console.WriteLine("Desea continuar? (s/n)");
                continuar = Console.ReadKey().KeyChar;
            }
            while (continuar == 's');
            
            /*
             * 6. Numero par o impar
             * Objetivo: El programa debe determinar si un numero entero ingresado por el usuario 
             * es par o impar y permitirle verificar multiples numeros.
            */
            int numero;
            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());
            do 
            {
                if (numero % 2 == 0)
                    {
                    Console.WriteLine("El numero es par");
                    }
                else {
                    Console.WriteLine("El numero no es par");
                }
                Console.WriteLine("Ingrese otro numero (0 para terminar)");
                numero = int.Parse(Console.ReadLine());
            }
            while (numero != 0);
            Console.WriteLine();
            /*
             * 7. Validad edad 
             * Objetivo: El programa debe determinar si el usuario es mayor o menor de edad basado 
             * en la edad ingresada y permitirle realizar multiples verificaciones. 
            */
            int edad;
            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine());
            do
            {
                if (edad >= 18) 
                {
                    Console.WriteLine("Es mayor de edad");
                }
                else
                {
                    Console.WriteLine("Es menor de edad");
                };
                Console.WriteLine("Ingrese edad (0 para terminar)");
                edad = int.Parse(Console.ReadLine());
            }
            while (edad != 0);
            /*
             * 8. Determinar la longitud de una cadena
             * Objetivo: El programa debe determinar la longitud de un texto ingresado por el usuario
             * y permitirle ingresar multiples textos 
            */
            string texto;
            int longitud ;
            do 
            {
                Console.WriteLine("Ingrese texto(0 para terminar)");
                texto = Console.ReadLine();
                longitud = texto.Length;
                Console.WriteLine("Longitud:" + longitud);
            }
            while (texto != "0");
            /*
             * 9. Calcular el area de un circulo
             * Objetivo: El programa debe calcular el area de un circulo basandose en el radio ingresado
             * por el usuario y permitirle realizar multiples calculos. 
            */
            double areaCirculo, radio;
            Console.WriteLine("Ingrese el radio (0 para finalizar)");
            radio = double.Parse(Console.ReadLine());
            do 
            {
                areaCirculo = Math.PI * radio * radio;
                Console.WriteLine("El area es:"+ areaCirculo) ;
                Console.WriteLine("Ingrese el radio (0 para finalizar)");
                radio = double.Parse(Console.ReadLine());
            }
            while (radio != 0);
            /*
             * 10. Convertir texto a mayusculas 
             * Objetivo: eL programa debe convertir un texto ingresado por el usuario a mayusculas y
             * permitirle conversiones. 
            */
            string texto, textoEnMayus;
            Console.WriteLine("Ingrese un texto");
            texto = Console.ReadLine();
            do 
            {
                Console.WriteLine("El texto pasado a mayuscula es:");
                textoEnMayus = texto.ToUpper();
                Console.WriteLine(textoEnMayus);
                Console.WriteLine("Ingrese un texto (0 para finalizar)");
                texto = Console.ReadLine();
            }
            while (texto != "0");
            /*
             * 11. Encontar el mayor de tres numeros 
             * Objetivo: El programa debe determinar el mayor de tres numeros ingresados por el usuario 
             * y permitirle realizar multiples comparaciones.
            */
            double valor1, valor2, valor3;
            char ingreso; 
            do 
            {
                Console.WriteLine("Ingrese valor 1");
                valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor 2");
                valor2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese valor 3");
                valor3 = double.Parse(Console.ReadLine());
                
                if (valor1 >= valor2 && valor1 >= valor3) 
                {
                    Console.WriteLine($"{valor1} es el mayor");
                }
                else
                    if  (valor2 >= valor1 && valor2 >= valor3)
                    {
                        Console.WriteLine($"{valor2} es el mayor");
                    }
                    else 
                    {
                        Console.WriteLine($"{valor3} es el mayor");
                    };
                
                Console.WriteLine("Desea ingresar datos?(S/N)");
                ingreso = Console.ReadKey().KeyChar;
            }
            while (ingreso == 's');
            Console.ReadLine();
        }
    }
}

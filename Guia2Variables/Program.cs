using System;

namespace guia1Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1)Promedio de edades: Pregunta 
            Ingresa las edades de tres personas y calcula el promedio de edad.
            */
            Console.WriteLine("Calculo de promedio de edades");
            int edad1 = 15, edad2 = 23, edad3 = 42;
            double sumatoria = (edad1 + edad2 + edad3) / 3;

            Console.WriteLine("el promedio es " + sumatoria);           
            //Forma alternativa
            //Console.WriteLine($"El promedio es {sumatoria}");  
            Console.WriteLine("las 3 edades son {0} {1} {2}", edad1, edad2, edad3);

            /*
            2)Area de un rectangulo:
            Ingresa la base y la altura de un rectangulo y calcula su area.
            */
            double vBase, vAltura;
            
            Console.WriteLine("Ingrese la base");
            vBase = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            vAltura = int.Parse(Console.ReadLine());

            double area = (vBase * vAltura);

            Console.WriteLine("el area del rectangulo es " + area);

            /*
            3)Descuento de una tienda:
            Ingresa el precio original de un producto y el procentaje de descuento aplicado
            Calcula el precio con descuento y muestra el resultado.
            */
            double precioOriginal, porcentajeDes, precioConDesc;
            
            Console.WriteLine("Ingrese el precio");
            precioOriginal = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el descuento ej 30.5");
            porcentajeDes = double.Parse(Console.ReadLine());
            
            precioConDesc = precioOriginal - (porcentajeDes * precioOriginal / 100);
            
            Console.WriteLine("El precio final es: "+ precioConDesc);

            /*
            4)Edades y sumatoria
            Ingrese las edades de tres personas y calcula la sumatoria de edad. 
            */
            int sumatoriaEdad;

            Console.WriteLine("Calculo de promedio de edades");
            
            Console.WriteLine("Ingrese edad 1");
            edad1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese edad 2");
            edad2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese edad 3");
            edad3 = int.Parse(Console.ReadLine());
            
            sumatoriaEdad = edad1 + edad2 + edad3;
            Console.WriteLine("La sumatoria de las edades es: " + sumatoriaEdad);

            /*
            5)Temperatura en grados Fahrenheit:
            Ingresa una temperatura en grados celsius y conviertela a grados Fahrenheit.
            */
            int tempCelsius, tempFahren;

            Console.WriteLine("Ingrese la temperatura en grados celsius");
            tempCelsius = int.Parse(Console.ReadLine());
            tempFahren = tempCelsius + 32;
            Console.WriteLine("La temperatura equivalente en grados fahrenheit es: " + tempFahren);

            /*
            6)Altura en pulgadas:
            Ingresa la altura en metros de una persona y muestra su equivalente en pulgadas.
            */
            double metrosPersona, pulgadasPersona;

            Console.WriteLine("Ingrese los metros de la persona");
            metrosPersona = double.Parse(Console.ReadLine());
            pulgadasPersona = metrosPersona * 39.37;
            Console.WriteLine("El equivalente a pulgadas es " + pulgadasPersona + " pulgadas");

            /*
            7)Calculo de IMC(Indice de masa corporal)
            Ingresa el peso en kilogramos y la altura en metros de una persona. Calcula su IMC y muestra el resultado.
            */
            double pesoKilos, alturaMetros, imc;
            
            Console.WriteLine("Ingrese el peso en kilos");
            pesoKilos = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura en metros");
            alturaMetros = double.Parse(Console.ReadLine());

            imc = (pesoKilos / (alturaMetros * alturaMetros)) ;

            Console.WriteLine("El IMC es: " +  imc);

            /*
            8)Edad de mascotas 
            Ingresa la edad en anios de una mascota y muestra su edad 
            equivalente en anios de humano (considerando una escala de
            un anio de mascota = 7 anios de humano)
            */
            int aniosHumanos;

            Console.WriteLine("Ingrese la edad de la mascota");
            aniosHumanos = int.Parse(Console.ReadLine()) * 7;
            Console.WriteLine("La mascota tiene un equivalente a " + aniosHumanos + " anios humanos");

            /*
            9)Tiempo de viaje
            Ingresa la distancia en kilometros y la velocidad en kilometros por hora
            para un viaje.
            Calcula el tiempo total del viaje en horas.
            */
            double distanciaKM, velocidadKM;

            Console.WriteLine("Ingrese la distancia en kilometros");
            distanciaKM = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad en kilometros");
            velocidadKM = double.Parse(Console.ReadLine());

            Console.WriteLine("El tiempo total es de " + distanciaKM / velocidadKM + " horas");
            /*
            10)Duracion de una pelicula:
            Ingresa la duracion en minutos de una pelicula y muestra la misma
            duracion en horas y minutos
            */

            /*
            11)Gastos de una salida:
            Ingresa el costo de la entrada de cine, el costo de la cena
            y el costo del transporte para una salida. Calcula el gasto total
            y muestra el resultado.
            */
            int costoCine, costoCena, costoTransporte, costoTotal;
            Console.WriteLine("Ingrese el valor de la entrada");
            costoCine = int.Parse( Console.ReadLine());
            Console.WriteLine("Ingrese el costo de la cena");
            costoCena = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el costo del transporte");
            costoTransporte = int.Parse(Console.ReadLine());
            costoTotal = costoCine + costoCena + costoTransporte;
            Console.WriteLine("El costo total es: " + costoTotal);

            /*
            12)Promedio de tres calificaciones:
            Ingresa tres calificaciones y calcula el promedio de las mismas
            */
            int nota1, nota2, nota3;

            Console.WriteLine("Ingrese la nota 1");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 2");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota 3");
            nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("El promedio de las notas es: " + ((nota1 + nota2 + nota3) / 3));

            /*
            13)Perimetro de un triangulo:
            Ingresa las longitudes de los tres lados de un triangulo
            y calcula su perimetro.
            */
            double longitud1, longitud2, longitud3;
            Console.WriteLine("Ingrese longitud lado 1");
            longitud1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese longitud lado 2");
            longitud2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese longitud lado 3");
            longitud3 = double.Parse(Console.ReadLine());

            Console.WriteLine("El perimetro del triangulo es:" + (longitud1 + longitud2 + longitud3));

            /*
            14)Cantidad de dolares en pesos argentinos.
            Ingresa la cotizacion del dolar y la cantidad de dolares a convertir
            Convierte la cantidad de dolares ingresada a pesos argentinos.
            */
            double cotizacionDolar, cantidadDolares;
            Console.WriteLine("Ingrese cotizacion del dolar");
            cotizacionDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de dolares");
            cantidadDolares = double.Parse(Console.ReadLine());
            Console.WriteLine("Corresponden a " + cotizacionDolar * cantidadDolares + " pesos");



            /*
            15)Area de un circulo
            Ingresa el radio de un circulo y calcula su area.
            */
            double radio;
            Console.WriteLine("Ingrese el radio del circulo");
            radio = double.Parse(Console.ReadLine());
            Console.WriteLine("El area del circulo es " + 3.1416*radio*radio);

            Console.ReadLine();
        }
    }
}

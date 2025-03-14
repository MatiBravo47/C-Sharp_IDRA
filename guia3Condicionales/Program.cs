using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Guia3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            1)Edad para conducir:
            a)Pregunta: Ingresa tu edad para determinar si puedes obtener 
            tu licencia de conducir.
            b)Variables: int (edad)
            c)Condicionales: if-else
            */

            /*
            int edad;
            string resultado;
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());
            resultado = edad > 18 ? "Puede conducir" : "No puede conducir";
            Console.WriteLine(resultado);
            Console.ReadLine();
            */

            /*
             2)Control de acceso:
             a)Pregunta: Ingresa tu nombre y edad para determinar si puedes acceder 
             a un evento
             b)Variables: int(edad), string(nombre)
             c)Condicionales: if-else
            */
            /*
            int edad;
            string nombre;

            Console.WriteLine("Ingresa tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu edad");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18 )
            {
                Console.WriteLine(nombre + " puede ingresar al evento");
            }
            else
            {
                Console.WriteLine(nombre + " no puede ingresar al evento");
            }
            Console.ReadLine();
            */

            /*
             * 3)Descuento de edad en cine:
             * Pregunta: Ingresa tu edad para determinar si tiene derecho a un aumento
             * Variables: int (edad)
             * Condicionales: if-else
             */
            /*
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >=18) 
            {
                Console.WriteLine("Tiene derecho a un aumento");
            }
            else
            {
                Console.WriteLine("No tiene derecho a un aumento");
            }
            Console.ReadLine();
            */
            /*
             * 4)Calificacion aprobatoria:
             * Pregunta: Ingresa tu califacion para saber si has aprobado
             * Variables: double (calificacion)
             * Condicionales: if-else
             */
            /*
            double calificacion;
            Console.WriteLine("Ingresa tu calificacion");
            calificacion = double.Parse(Console.ReadLine());
            if (calificacion >= 4)
            {
                Console.WriteLine("Has aprobado");
            }
            else
            {
                Console.WriteLine("Has desaprobado");
            }
            Console.ReadLine();
            */
            /*
            * 5)Verificacion de contrasenia:
            * Pregunta: Ingresa una contrasenia para verificar si es correcta
            * Variables: string (contrasenia)
            * Condicionales: if-else
            */
            /*
            string contra = "idra1234";
            string contrasenia;
            Console.WriteLine("Ingrese la contrasenia");
            contrasenia = Console.ReadLine();
            if (contra == contrasenia)
            {
                Console.WriteLine("La contrasenia es correcta");
            }
            else
            {
                Console.WriteLine("La contrasenia es incorrecta");
            }
            Console.ReadLine();
            */

            /*
            *6)Comprobacion de edad para redes sociales:
            *Pregunta: Ingresa tu edad para saber si puedes crear una cuenta en redes sociales
            *Variables: byte (edad)
            * Condicionales: if-else
            */
            /*
            byte edad;
            Console.WriteLine("Ingrese edad");
            edad = Byte.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Puede crear una cuenta");
            }
            else
            {
                Console.WriteLine("No puede crear una cuenta");
            }
            Console.ReadLine();
            */
            /*
            *7)Calculo de impuestos:
            *Pregunta: Ingresa tu salario mensual para calcular tus impuestos
            *Variables: double(salario)
            * Condicionales: if-else
            */
            /*
            *8)Control de acceso a un bar:
            *Pregunta: Ingresa tu nombre y edad para determinar si puedes entrar a un bar
            *Variables: string(nombre), int(edad)
            * Condicionales: if-else
            */
            /*
            string nombre;
            int edad;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine());
            if (edad > 17) 
            {
                Console.WriteLine("Puede entrar");
            }
            else
            {
                Console.WriteLine("No puede entrar");
            }
            Console.ReadLine();
            */
            /*
            *9)Verificacion de asistencia a clase:
            *Pregunta: Ingresa el numero de veces que asiste a clase para determinar 
            *si has alcanzado el minimo requerido
            *Variables: int(asistencias)
            * Condicionales: if-else
            */
            /*
            int asistencias;
            Console.WriteLine("Ingrese la cantidad de asistencias");
            asistencias = int.Parse(Console.ReadLine());
            if (asistencias >= 50)
            {
                Console.WriteLine("Superaste el minimo de asistencias requerido");
            }
            else
            {
                Console.WriteLine("No superaste el minimo de asistencias requerido");
            }
            Console.ReadLine();
            */
            /*
            *10)Validacion de numero de telefono:
            *Pregunta: Ingresa tu numero de telefono para verificar si es valido
            *Variables: string(numero de telefono).
            * Condicionales: if-else
            */
            /*
            string telefono;
            Console.WriteLine("Ingrese numero de telefono sin 0 ni 15");
            telefono = Console.ReadLine();
            int longitud = telefono.Length;
            if (longitud == 10)
            {
                Console.WriteLine("El telefono es correcto");
            } 
            else
            {
                Console.WriteLine("El telefono es incorrecto");
            }
            Console.ReadLine();
            */
            /*
            *11)Calculo de descuento en tienda:
            *Pregunta: Ingresa el monto de tu compra para calcular el descuento aplicable
            *Variables: double (monto de compra)
            * Condicionales: if-else
            */
            /*
            double montoCompra;
            Console.WriteLine("Ingrese monto de la compra");
            montoCompra = Double.Parse(Console.ReadLine());
            if (montoCompra >= 200000) 
            {
                Console.WriteLine("Tiene descuento del 30%");
            }
            else
            {
                Console.WriteLine("No tiene descuento del 30%");
            }
            Console.ReadLine();
            */
            /*
            *12)Verificacion de disponibilidad de producto:
            *Pregunta: Ingresa la cantidad de un producto para verificar si esta disponible en inventario
            *Variables: int(cantidad de producto)
            * Condicionales: if-else
            */
            /*
            int total = 50;
            int cantidadProducto;
            Console.WriteLine("Ingrese la cantidad");
            cantidadProducto = int.Parse(Console.ReadLine());
            if (cantidadProducto > total)
            {
                Console.WriteLine("No esta disponible esa cantidad");
            }
            else 
            {
                Console.WriteLine("Esta disponible");
            }
            Console.ReadLine();
            */
            /*
            *13)Aprobacion de un credito:
            *Pregunta: Ingresa tu puntaje de credito para determinar si eres elegible para un prestamo
            *Variables: int (puntaje de credito)
            * Condicionales: if-else
            */
            /*
            int puntajeCredito;
            Console.WriteLine("Ingrese su puntaje de credito");
            puntajeCredito = int.Parse(Console.ReadLine());
            if (puntajeCredito >= 100)
            {
                Console.WriteLine("Puede sacar un prestamo");
            }
            else
            {
                Console.WriteLine("No puede sacar un prestamo");
            }
            Console.ReadLine();
            */
            /*
            *14)Validacion de correo electronico :
            *Pregunta: Ingresa tu correo electronico para verificar si tiene un formato valido
            *Variables: string (correo electronico)
            * Condicionales: if-else
            */
            /*
            *15)Comprobacion de disponibilidad :
            *Pregunta: Ingresa el numero de asientos que deseas reservar para verificar si estan disponibles
            *Variables: int (cantidad de asientos)
            * Condicionales: if-else
            */
            int cantidadAsientos;
            Console.WriteLine("Ingrese cantidad de asientos que quiere reservar");
            cantidadAsientos = int.Parse(Console.ReadLine());
            if (cantidadAsientos <= 50)
            {
                Console.WriteLine("Estan disponibles");
            }
            else
            {
                Console.WriteLine("No estan disponibles");
            }
            Console.ReadLine();
        }
    }
}

# Practica Final de Programación

Este proyecto es una aplicación de consola interactiva desarrollada en C#. El objetivo principal es gestionar datos mediante un programa modular que incluye un menú con seis opciones. Cada función está diseñada para trabajar con un conjunto de datos y aplicar diversas operaciones de manipulación y análisis.

## Funcionalidades

El programa presenta un menú interactivo con las siguientes opciones:

1. **Cargar elementos**  
   Permite ingresar 6 cadenas de texto (strings) en un arreglo, validando que no estén vacías.  
   
2. **Mostrar elementos ordenados**  
   Ordena alfabéticamente los elementos del arreglo utilizando el método de burbuja y los muestra por consola.

3. **Ingresar valores**  
   Permite al usuario ingresar valores numéricos en una matriz 4x6 (4 filas, 6 columnas), validando cada entrada.

4. **Mostrar valores**  
   Muestra los valores almacenados en la matriz, vinculando cada fila con los elementos del arreglo de cadenas.

5. **Convertir a lista dinámica**  
   Convierte los datos de la matriz a una lista dinámica de structs, haciendo uso de una estructura definida para este propósito.

6. **Calcular y mostrar promedios**  
   Calcula el promedio de los valores de la matriz para cada elemento transferido a la lista y muestra los resultados.

## Requisitos Técnicos

- **Arreglo Unidimensional**  
  Un arreglo de 6 cadenas de texto representando los elementos principales (en este caso, nombres de pilotos de F1).

- **Matriz 4x6**  
  Una matriz que relaciona los nombres de los pilotos con puntos obtenidos en distintos circuitos.

- **Struct**  
  Un struct que almacena los valores correspondientes a los puntos obtenidos por cada piloto.

- **Funciones Modulares**  
  Cada opción del menú está implementada como una función separada.

- **Validaciones**  
  Validación de entradas de datos para evitar valores inválidos o vacíos.

## Tecnologías

- Lenguaje: C#
- Entorno: Aplicación de consola .NET

## Cómo usar el programa

1. Clona este repositorio:  
   ```bash
   git clone <URL-del-repo>
   cd practicaFinalProgramacion

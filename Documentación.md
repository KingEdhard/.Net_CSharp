![Logo del curso] (Logo_curso_C#.jpeg)


# Curso básico de C# y .Net Core

Bienvenido al curso básico de C#, donde aprenderás los fundamentos necesarios para comenzar a desarrollar aplicaciones utilizando .Net Core. Este curso está dirigido a personas que quieren iniciarse en el mundo de la programación con C#, uno de los lenguajes más populares y versátiles del mercado. Para tomar este curso, solo necesitas tener conocimientos básicos de informática y lógica. Al finalizar el curso, serás capaz de crear tus propias aplicaciones con C# y .Net Core, utilizando las herramientas y las buenas prácticas que te enseñaremos.

## Tabla de contenidos

- [Introducción a C# y .Net Core](#introducción-a-c-y-net-core)
- [Configuración del entorno de desarrollo](#configuración-del-entorno-de-desarrollo)
- [Sintaxis básica de C#](#sintaxis-básica-de-c)
- [Tipos de datos primitivos](#tipos-de-datos-primitivos)
- [Operadores y expresiones](#operadores-y-expresiones)
- [Estructuras de control](#estructuras-de-control)
- [Arreglos y colecciones](#arreglos-y-colecciones)
- [Métodos y funciones](#métodos-y-funciones)
- [Clases y objetos](#clases-y-objetos)
- [Herencia y polimorfismo](#herencia-y-polimorfismo)
- [Interfaces y abstracción](#interfaces-y-abstracción)
- [Excepciones y manejo de errores](#excepciones-y-manejo-de-errores)
- [Entrada y salida de datos](#entrada-y-salida-de-datos)
- [Proyectos con .Net Core](#proyectos-con-net-core)

## Introducción a C# y .Net Core

C# es un lenguaje de programación orientado a objetos, multiplataforma y de propósito general, diseñado por Microsoft en el año 2000. C# se basa en el estándar ECMA-334 y forma parte del proyecto .NET, una plataforma de desarrollo que ofrece un conjunto de servicios, herramientas y librerías para crear aplicaciones robustas, escalables y seguras.

.Net Core es una versión moderna, modular y de código abierto de la plataforma .NET, que permite desarrollar aplicaciones para Windows, Linux, macOS, iOS, Android y más. .Net Core ofrece un entorno de ejecución común (CLR), un conjunto de librerías estándar (BCL) y un compilador multiplataforma (Roslyn) que facilitan el desarrollo con C#.

Algunas ventajas de utilizar C# y .Net Core en el desarrollo de aplicaciones son:

- La sintaxis de C# es clara, concisa y expresiva, lo que facilita la lectura y escritura del código.
- C# es un lenguaje multiparadigma, que soporta programación orientada a objetos, funcional, imperativa, declarativa y más.
- C# es un lenguaje fuertemente tipado, lo que ayuda a prevenir errores en tiempo de compilación y ejecución.
- C# es un lenguaje compilado, lo que mejora el rendimiento y la optimización del código.
- C# es un lenguaje seguro, lo que evita problemas como desbordamiento de búfer, punteros nulos o acceso no autorizado a la memoria.
- .Net Core es una plataforma multiplataforma, lo que permite desarrollar aplicaciones que se ejecuten en diferentes sistemas operativos sin necesidad de modificar el código.
- .Net Core es una plataforma modular, lo que permite seleccionar solo las librerías o componentes que se necesiten para cada aplicación, reduciendo el tamaño y la complejidad del proyecto.
- .Net Core es una plataforma de código abierto, lo que permite acceder al código fuente, contribuir al desarrollo o personalizar la plataforma según las necesidades.

## Configuración del entorno de desarrollo

Para empezar a desarrollar aplicaciones con C# y .Net Core, se necesita configurar el entorno de desarrollo con las siguientes herramientas:

- Un editor o IDE (Entorno de Desarrollo Integrado) que soporte C# y .Net Core. Se puede usar Visual Studio, Visual Studio Code o cualquier otro editor de preferencia.
- El SDK (Kit de Desarrollo de Software) de .Net Core, que incluye el compilador, el entorno de ejecución, las librerías y las herramientas de línea de comandos para desarrollar aplicaciones con .Net Core.
- Un sistema de control de versiones, como Git, que permite gestionar los cambios en el código fuente, colaborar con otros desarrolladores y mantener un historial del proyecto.

Para instalar y configurar estas herramientas, se puede seguir los pasos que se indican en los siguientes enlaces:

- [Instalar Visual Studio](https://docs.microsoft.com/es-es/visualstudio/install/install-visual-studio?view=vs-2022)
- [Instalar Visual Studio Code](https://code.visualstudio.com/docs/setup/setup-overview)
- [Instalar el SDK de .Net Core](https://docs.microsoft.com/es-es/dotnet/core/install/)
- [Instalar Git](https://git-scm.com/book/es/v2/Inicio---Sobre-el-Control-de-Versiones-Instalación-de-Git)

## Sintaxis básica de C#

La sintaxis básica de C# se refiere a las reglas y convenciones que se deben seguir para escribir código válido en este lenguaje. Algunos aspectos importantes de la sintaxis básica de C# son:

- C# es un lenguaje sensible a mayúsculas y minúsculas, lo que significa que distingue entre letras mayúsculas y minúsculas. Por ejemplo, las variables nombre y Nombre son diferentes y no se pueden usar indistintamente.
- C# utiliza el punto y coma (;) para indicar el final de una instrucción o sentencia. Una instrucción es una unidad mínima de ejecución que realiza una acción o tarea. Por ejemplo, la instrucción Console.WriteLine("Hola Mundo"); muestra el mensaje "Hola Mundo" en la consola.
- C# utiliza las llaves ({}) para delimitar el inicio y el fin de un bloque de código. Un bloque de código es un conjunto de instrucciones que se ejecutan como una unidad. Por ejemplo, el bloque de código if (condicion) { ... } se ejecuta solo si la condición es verdadera.
- C# utiliza los comentarios para agregar información adicional al código que no afecta su funcionamiento. Los comentarios sirven para documentar, explicar o aclarar el código. Hay dos tipos de comentarios en C#: los comentarios de una línea, que empiezan con // y terminan al final de la línea, y los comentarios de varias líneas, que empiezan con /* y terminan con */. Por ejemplo:

```csharp
// Este es un comentario de una línea
Console.WriteLine("Hola Mundo"); // Muestra un mensaje en la consola

/* Este es un comentario
de varias líneas */
Console.WriteLine("Adiós Mundo"); // Muestra otro mensaje en la consola
```

A continuación, se muestra un ejemplo de un programa simple en C# que muestra un mensaje en la consola:

```csharp
// Programa simple en C#
using System; // Importa el espacio de nombres System

namespace CursoCSharp // Define el espacio de nombres CursoCSharp
{
    class Program // Define la clase Program
    {
        static void Main(string[] args) // Define el método Main, que es el punto de entrada del programa
        {
            Console.WriteLine("Hola Mundo"); // Muestra el mensaje "Hola Mundo" en la consola
        }
    }
}
```

## Tipos de datos primitivos

Los tipos de datos primitivos son los tipos más básicos y simples que ofrece C#, que representan valores numéricos, lógicos o textuales. Los tipos de datos primitivos se dividen en dos categorías: los tipos por valor y los tipos por referencia.

Los tipos por valor almacenan directamente el valor en una variable, mientras que los tipos por referencia almacenan una referencia o dirección a un objeto en memoria donde se guarda el valor. Los tipos por valor son más eficientes y rápidos, pero ocupan más espacio y no permiten la modificación del valor original. Los tipos por referencia son más flexibles y dinámicos, pero requieren más procesamiento y pueden generar errores si no se manejan correctamente.

Los tipos por valor incluyen los siguientes tipos primitivos:

- byte: Es un tipo de dato entero sin signo que puede almacenar valores entre 0 y 255. Se puede usar para representar datos binarios o números pequeños. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- sbyte: Es un tipo de dato entero con signo que puede almacenar valores entre -128 y 127. Se puede usar para representar datos binarios o números pequeños. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- short: Es un tipo de dato entero con signo que puede almacenar valores entre -32.768 y 32.767. Se puede usar para representar números enteros medianos. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- ushort: Es un tipo de dato entero sin signo que puede almacenar valores entre 0 y 65.535. Se puede usar para representar números enteros medianos. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- int: Es un tipo de dato entero con signo que puede almacenar valores entre -2.147.483.648 y 2.147.483.647. Se puede usar para representar números enteros grandes. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- uint: Es un tipo de dato entero sin signo que puede almacenar valores entre 0 y 4.294.967.295. Se puede usar para representar números enteros grandes. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- long: Es un tipo de dato entero con signo que puede almacenar valores entre -9.223.372.036.854.775.808 y 9.223.372.036.854.775.807. Se puede usar para representar números enteros muy grandes. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- ulong: Es un tipo de dato entero sin signo que puede almacenar valores entre 0 y 18.446.744.073.709.551.615. Se puede usar para representar números enteros muy grandes. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- float: Es un tipo de dato de punto flotante con signo que puede almacenar valores aproximados entre -3,4E+38 y 3,4E+38, con una precisión de 7 dígitos decimales. Se puede usar para representar números reales pequeños o con poca precisión. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- double: Es un tipo de dato de punto flotante con signo que puede almacenar valores aproximados entre -1,7E+308 y 1,7E+308, con una precisión de 15 dígitos decimales. Se puede usar para representar números reales grandes o con más precisión que el float. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- decimal: Es un tipo de dato de punto flotante con signo que puede almacenar valores exactos entre -7,9E+28 y 7,9E+28, con una precisión de 28 dígitos decimales. Se puede usar para representar números reales con mucha precisión, como los valores monetarios o financieros. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- char: Es un tipo de dato alfanumérico que puede almacenar un solo carácter Unicode, como una letra, un número o un símbolo. Se puede usar para representar datos textuales simples o individuales. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().
- string: Es un tipo de dato alfanumérico que puede almacenar una secuencia de caracteres Unicode, como una palabra, una frase o un texto. Se puede usar para representar datos textuales complejos o múltiples. Algunos métodos que se pueden aplicar a este tipo son Length, IndexOf(), Concat(), Substring(), Replace(), ToUpper(), ToLower() y más.
- bool: Es un tipo de dato lógico que puede almacenar un valor verdadero o falso. Se puede usar para representar condiciones, estados o resultados binarios. Algunos métodos que se pueden aplicar a este tipo son Parse(), TryParse(), ToString(), GetHashCode() y Equals().

A continuación, te muestro algunos ejemplos de cómo declarar, inicializar y usar estos tipos de datos primitivos en C#:

```csharp
// Declaración e inicialización de variables de tipos primitivos
byte b = 200; // Un valor entre 0 y 255
sbyte sb = -100; // Un valor entre -128 y 127
short s = 30000; // Un valor entre -32768 y 32767
ushort us = 60000; // Un valor entre 0 y 65535
int i = 1000000000; // Un valor entre -2147483648 y 2147483647
uint ui = 4000000000; // Un valor entre 0 y 4294967295
long l = 1000000000000000000; // Un valor entre -9223372036854775808 y 9223372036854775807
ulong ul = 10000000000000000000; // Un valor entre 0 y 18446744073709551615
float f = 3.14f; // Un valor aproximado con una precisión de 7 dígitos decimales
double d = 3.141592653589793; // Un valor aproximado con una precisión de 15 dígitos decimales
decimal m = 3.1415926535897932384626433832m; // Un valor exacto con una precisión de 28 dígitos decimales
char c = 'A'; // Un carácter Unicode
string str = "Hola Mundo"; // Una cadena de caracteres Unicode
bool b = true; // Un valor lógico

// Uso de métodos para convertir, comparar o mostrar los valores
Console.WriteLine(b.ToString()); // Muestra "200"
Console.WriteLine(sb.GetHashCode()); // Muestra un código hash del valor de sb
Console.WriteLine(s.Equals(30000)); // Muestra "True"
Console.WriteLine(ushort.Parse("50000")); // Convierte la cadena "50000" en un ushort
Console.WriteLine(ui.CompareTo(3000000000)); // Compara ui con otro uint y muestra 1 si es mayor, -1 si es menor o 0 si es igual
Console.WriteLine(ulong.TryParse("123456789", out ulong result)); // Intenta convertir la cadena "123456789" en un ulong y lo almacena en result, devuelve true si tiene éxito o false si falla
Console.WriteLine(f.ToString("F2")); // Muestra "3.14" con dos decimales
Console.WriteLine(d.GetHashCode()); // Muestra un código hash del valor de d
Console.WriteLine(m.Equals(3.1415926535897932384626433832m)); // Muestra "True"
Console.WriteLine(c.ToString()); // Muestra "A"
Console.WriteLine(str.Length); // Muestra "10"
Console.WriteLine(str.IndexOf("Mundo")); // Muestra "5"
Console.WriteLine(str.Concat(" ", "Adiós")); // Muestra "Hola Mundo Adiós"
Console.WriteLine(str.Substring(0,4)); // Muestra "Hola"
Console.WriteLine(str.Replace("Mundo", "Planeta")); // Muestra "Hola Planeta"
Console.WriteLine(str.ToUpper()); // Muestra "HOLA MUNDO"
Console.WriteLine(str.ToLower()); // Muestra "hola mundo"
Console.WriteLine(b.ToString()); // Muestra "True"
```

## Operadores y expresiones.

Operadores y expresiones son conceptos fundamentales en la programación, que permiten manipular y combinar valores, variables y funciones para crear algoritmos y lógicas. Los operadores son símbolos o palabras clave que indican qué tipo de operación se va a realizar con los operandos, que son los elementos sobre los que actúa el operador. Las expresiones son combinaciones de operadores y operandos que producen un resultado o valor.

Existen diferentes tipos de operadores según el tipo de operación que realizan o el número de operandos que requieren. Algunos tipos de operadores comunes son:

- Operadores aritméticos: realizan operaciones matemáticas con valores numéricos, como suma, resta, multiplicación, división o resto. Por ejemplo: `a + b`, `c - d`, `e * f`, `g / h`, `i % j`.
- Operadores relacionales: comparan valores numéricos o alfanuméricos y devuelven un valor lógico (verdadero o falso) según el resultado de la comparación. Por ejemplo: `a < b`, `c > d`, `e == f`, `g != h`, `i <= j`, `k >= l`.
- Operadores lógicos: realizan operaciones lógicas con valores booleanos (verdadero o falso) y devuelven un valor booleano según el resultado de la operación. Por ejemplo: `a && b` (y lógico), `c || d` (o lógico), `!e` (negación lógica).
- Operadores de asignación: asignan un valor a una variable o a una propiedad de un objeto. Por ejemplo: `a = b` (asignación simple), `c += d` (asignación con suma), `e -= f` (asignación con resta), `g *= h` (asignación con multiplicación), `i /= j` (asignación con división), `k %= l` (asignación con resto).
- Operadores de incremento y decremento: aumentan o disminuyen en una unidad el valor de una variable o de una propiedad de un objeto. Por ejemplo: `a++` (incremento posfijo), `++b` (incremento prefijo), `c--` (decremento posfijo), `--d` (decremento prefijo).
- Operadores condicionales: evalúan una condición y devuelven un valor según el resultado de la evaluación. Por ejemplo: `a ? b : c` (operador ternario), que devuelve el valor de b si a es verdadero, o el valor de c si a es falso; `d ?? e` (operador de coalescencia nula), que devuelve el valor de d si no es nulo, o el valor de e si d es nulo.

Las expresiones se forman combinando operadores y operandos siguiendo unas reglas de sintaxis y unas prioridades. La sintaxis determina cómo se deben escribir las expresiones para que sean válidas y comprensibles para el compilador o el intérprete. La prioridad determina el orden en el que se deben evaluar los operadores dentro de una expresión, según su importancia relativa. Los paréntesis se pueden usar para modificar el orden de evaluación impuesto por la prioridad, dando preferencia a las expresiones entre paréntesis.

A continuación, se muestran algunos ejemplos de expresiones válidas en C#, junto con sus resultados:

```csharp
int a = 10; // Asigna el valor 10 a la variable a
int b = 5; // Asigna el valor 5 a la variable b
int c = a + b; // Asigna el resultado de sumar a y b a la variable c
Console.WriteLine(c); // Muestra el valor de c en la consola, que es 15
bool d = a > b; // Asigna el resultado de comparar si a es mayor que b a la variable d
Console.WriteLine(d); // Muestra el valor de d en la consola, que es true
bool e = a < b && c > a; // Asigna el resultado de evaluar la expresión lógica a la variable e
Console.WriteLine(e); // Muestra el valor de e en la consola, que es false
int f = a * b + c; // Asigna el resultado de multiplicar a por b y sumarle c a la variable f
Console.WriteLine(f); // Muestra el valor de f en la consola, que es 65
int g = (a + b) * c; // Asigna el resultado de sumar a y b y multiplicar el resultado por c a la variable g
Console.WriteLine(g); // Muestra el valor de g en la consola, que es 225
int h = a % b; // Asigna el resto de dividir a entre b a la variable h
Console.WriteLine(h); // Muestra el valor de h en la consola, que es 0
int i = a++; // Asigna el valor de a a la variable i y luego incrementa a en una unidad
Console.WriteLine(i); // Muestra el valor de i en la consola, que es 10
Console.WriteLine(a); // Muestra el valor de a en la consola, que es 11
int j = ++b; // Incrementa b en una unidad y luego asigna el valor de b a la variable j
Console.WriteLine(j); // Muestra el valor de j en la consola, que es 6
Console.WriteLine(b); // Muestra el valor de b en la consola, que es 6
int k = a > b ? a : b; // Asigna el valor de a si a es mayor que b, o el valor de b si no, a la variable k
Console.WriteLine(k); // Muestra el valor de k en la consola, que es 11
string l = null; // Asigna el valor nulo a la variable l
string m = l ?? "Hola"; // Asigna el valor de l si no es nulo, o la cadena "Hola" si l es nulo, a la variable m
Console.WriteLine(m); // Muestra el valor de m en la consola, que es "Hola"
```

## Estructuras de control.

Las estructuras de control son las que permiten modificar el flujo de ejecución de las instrucciones en un programa, según ciertas condiciones o repeticiones. Existen dos tipos principales de estructuras de control: las estructuras condicionales y las estructuras iterativas.

Las estructuras condicionales son las que permiten ejecutar un bloque de código solo si se cumple una condición, o ejecutar un bloque u otro según el resultado de una condición. Por ejemplo, la estructura if-else permite ejecutar un bloque si la condición es verdadera, o ejecutar otro bloque si la condición es falsa. La sintaxis general de esta estructura es la siguiente:

```csharp
if (condicion)
{
    // Bloque de código que se ejecuta si la condición es verdadera
}
else
{
    // Bloque de código que se ejecuta si la condición es falsa
}
```

Un ejemplo de uso de esta estructura es el siguiente:

```csharp
int edad = 18; // Declara e inicializa una variable entera llamada edad
if (edad >= 18) // Evalúa si la edad es mayor o igual que 18
{
    Console.WriteLine("Eres mayor de edad"); // Muestra el mensaje "Eres mayor de edad" en la consola si la condición es verdadera
}
else
{
    Console.WriteLine("Eres menor de edad"); // Muestra el mensaje "Eres menor de edad" en la consola si la condición es falsa
}
```

Otro ejemplo de estructura condicional es la estructura switch-case, que permite ejecutar un bloque de código u otro según el valor de una expresión. La sintaxis general de esta estructura es la siguiente:

```csharp
switch (expresion)
{
    case valor1:
        // Bloque de código que se ejecuta si la expresión tiene el valor1
        break;
    case valor2:
        // Bloque de código que se ejecuta si la expresión tiene el valor2
        break;
    ...
    default:
        // Bloque de código que se ejecuta si la expresión no tiene ninguno de los valores anteriores
        break;
}
```

Un ejemplo de uso de esta estructura es el siguiente:

```csharp
int mes = 12; // Declara e inicializa una variable entera llamada mes
switch (mes) // Evalúa el valor de la variable mes
{
    case 1:
        Console.WriteLine("Enero"); // Muestra el nombre del mes en la consola si el valor es 1
        break;
    case 2:
        Console.WriteLine("Febrero"); // Muestra el nombre del mes en la consola si el valor es 2
        break;
    case 3:
        Console.WriteLine("Marzo"); // Muestra el nombre del mes en la consola si el valor es 3
        break;
    ...
    case 12:
        Console.WriteLine("Diciembre"); // Muestra el nombre del mes en la consola si el valor es 12
        break;
    default:
        Console.WriteLine("Mes inválido"); // Muestra un mensaje de error en la consola si el valor no está entre 1 y 12
        break;
}
```

Las estructuras iterativas son las que permiten repetir un bloque de código mientras se cumpla una condición, o un número determinado de veces. Por ejemplo, la estructura while permite repetir un bloque de código mientras la condición sea verdadera. La sintaxis general de esta estructura es la siguiente:

```csharp
while (condicion)
{
    // Bloque de código que se repite mientras la condición sea verdadera
}
```

Un ejemplo de uso de esta estructura es el siguiente:

```csharp
int contador = 1; // Declara e inicializa una variable entera llamada contador
while (contador <= 10) // Evalúa si el contador es menor o igual que 10
{
    Console.WriteLine(contador); // Muestra el valor del contador en la consola mientras la condición sea verdadera
    contador++; // Incrementa el contador en una unidad cada vez que se repite el bloque
}
```

Otro ejemplo de estructura iterativa es la estructura for, que permite repetir un bloque de código un número determinado de veces, controlando una variable contador. La sintaxis general de esta estructura es la siguiente:

```csharp
for (inicializacion; condicion; incremento)
{
    // Bloque de código que se repite según la inicialización, la condición y el incremento
}
```

Un ejemplo de uso de esta estructura es el siguiente:

```csharp
for (int i = 1; i <= 10; i++) // Declara e inicializa una variable entera llamada i, evalúa si i es menor o igual que 10, e incrementa i en una unidad cada vez que se repite el bloque
{
    Console.WriteLine(i); // Muestra el valor de i en la consola mientras la condición sea verdadera
}
```

## Arreglos y Colecciones.

El siguiente punto del temario es Arreglos y colecciones. Los arreglos y las colecciones son dos formas de almacenar y manipular datos en C#, pero tienen algunas diferencias importantes que hay que tener en cuenta. En esta sección, veremos qué son los arreglos y las colecciones, cómo se declaran, inicializan y usan, y qué ventajas y desventajas tienen cada uno.

Los arreglos son estructuras de datos que almacenan una secuencia de elementos del mismo tipo, ordenados por un índice numérico. Los arreglos se pueden crear usando la palabra clave new seguida del tipo de los elementos y el tamaño del arreglo entre corchetes. Por ejemplo:

```csharp
// Crear un arreglo de enteros de tamaño 5
int[] numeros = new int[5];

// Crear un arreglo de cadenas de tamaño 3 e inicializarlo con valores
string[] nombres = new string[3] { "Ana", "Luis", "Pedro" };
```

Los elementos de un arreglo se pueden acceder o modificar usando el operador de indexación [], que recibe el índice del elemento entre corchetes. El primer elemento tiene el índice 0 y el último tiene el índice tamaño - 1. Por ejemplo:

```csharp
// Acceder al primer elemento del arreglo numeros
int primero = numeros[0];

// Acceder al último elemento del arreglo nombres
string ultimo = nombres[nombres.Length - 1];

// Modificar el segundo elemento del arreglo numeros
numeros[1] = 10;

// Modificar el tercer elemento del arreglo nombres
nombres[2] = "María";
```

Los arreglos tienen algunas propiedades y métodos que se pueden usar para obtener información o realizar operaciones sobre ellos. Algunas de estas propiedades y métodos son:

- Length: devuelve el número de elementos del arreglo.
- Rank: devuelve el número de dimensiones del arreglo.
- GetLength(int dimension): devuelve el número de elementos en la dimensión especificada del arreglo.
- CopyTo(Array array, int index): copia los elementos del arreglo actual al arreglo especificado, empezando por el índice especificado.
- Clone(): devuelve una copia superficial del arreglo actual.
- Sort(): ordena los elementos del arreglo usando el comparador predeterminado.
- Reverse(): invierte el orden de los elementos del arreglo.

Los arreglos tienen algunas ventajas, como:

- Son rápidos y eficientes para acceder a los elementos por su índice.
- Tienen una sintaxis simple y concisa para declararlos e inicializarlos.
- Tienen compatibilidad con la sintaxis del lenguaje C# para recorrerlos con bucles for o foreach.

Sin embargo, los arreglos también tienen algunas desventajas, como:

- Tienen un tamaño fijo que no se puede cambiar una vez creado el arreglo.
- Solo pueden almacenar elementos del mismo tipo, lo que limita su flexibilidad.
- No tienen muchos métodos útiles para manipular los elementos, como agregar, eliminar o buscar.

Las colecciones son estructuras de datos que almacenan una secuencia de elementos que pueden ser de diferentes tipos, dependiendo de la implementación de la colección. Las colecciones se pueden crear usando las clases o interfaces provistas por el espacio de nombres System.Collections o System.Collections.Generic. Por ejemplo:

```csharp
// Crear una lista genérica de enteros usando la clase List<T>
List<int> numeros = new List<int>();

// Crear una lista genérica de cadenas usando la clase List<T> e inicializarla con valores
List<string> nombres = new List<string> { "Ana", "Luis", "Pedro" };

// Crear un diccionario genérico que asocia cadenas con enteros usando la clase Dictionary<TKey,TValue>
Dictionary<string, int> edades = new Dictionary<string, int>();
```

Los elementos de una colección se pueden acceder o modificar usando diferentes métodos o propiedades, dependiendo del tipo de la colección. Algunos tipos de colecciones permiten acceder a los elementos por su índice, como las listas, mientras que otros permiten acceder a los elementos por su clave, como los diccionarios. Por ejemplo:

```csharp
// Acceder al primer elemento de la lista numeros
int primero = numeros[0];

// Acceder al último elemento de la lista nombres
string ultimo = nombres[nombres.Count - 1];

// Modificar el segundo elemento de la lista numeros
numeros[1] = 10;

// Modificar el tercer elemento de la lista nombres
nombres[2] = "María";

// Agregar un elemento al diccionario edades con la clave "Ana" y el valor 20
edades.Add("Ana", 20);

// Acceder al elemento del diccionario edades con la clave "Ana"
int edad = edades["Ana"];

// Modificar el elemento del diccionario edades con la clave "Ana"
edades["Ana"] = 21;
```

Las colecciones tienen algunas propiedades y métodos que se pueden usar para obtener información o realizar operaciones sobre ellas. Algunas de estas propiedades y métodos son:

- Count: devuelve el número de elementos de la colección.
- Add(T item): agrega un elemento al final de la colección.
- Insert(int index, T item): inserta un elemento en la posición especificada de la colección.
- Remove(T item): elimina la primera ocurrencia del elemento especificado de la colección.
- RemoveAt(int index): elimina el elemento en la posición especificada de la colección.
- Clear(): elimina todos los elementos de la colección.
- Contains(T item): devuelve true si la colección contiene el elemento especificado, o false en caso contrario.
- IndexOf(T item): devuelve el índice de la primera ocurrencia del elemento especificado en la colección, o -1 si no se encuentra.

Las colecciones tienen algunas ventajas, como:

- Tienen un tamaño dinámico que se puede aumentar o reducir según se agreguen o eliminen elementos.
- Pueden almacenar elementos de diferentes tipos, lo que aumenta su flexibilidad.
- Tienen muchos métodos útiles para manipular los elementos, como agregar, eliminar o buscar.

Sin embargo, las colecciones también tienen algunas desventajas, como:

- Son más lentas y menos eficientes que los arreglos para acceder a los elementos por su índice.
- Tienen una sintaxis más compleja y verbosa para declararlas e inicializarlas.
- Requieren importar los espacios de nombres System.Collections o System.Collections.Generic para usarlas.

En conclusión, los arreglos y las colecciones son dos formas de almacenar y manipular datos en C#, pero tienen algunas diferencias importantes que hay que tener en cuenta. Los arreglos son más adecuados para almacenar datos homogéneos y fijos, mientras que las colecciones son más adecuadas para almacenar datos heterogéneos y dinámicos. La elección entre uno u otro dependerá de las necesidades y preferencias de cada programador.

## Clases y objetos

Las clases y los objetos son conceptos fundamentales de la programación orientada a objetos, que es el paradigma que sigue el lenguaje C#. En esta sección, veremos qué son las clases y los objetos, cómo se declaran, instancian y usan, y qué ventajas y desventajas tienen cada uno.

Las clases son estructuras de datos que definen las características y el comportamiento de una entidad o concepto. Las clases se pueden crear usando la palabra clave class seguida del nombre de la clase y las llaves que delimitan el cuerpo de la clase. Por ejemplo:

```csharp
// Crear una clase llamada Persona
class Persona
{
    // Cuerpo de la clase
}
```

Dentro del cuerpo de la clase se pueden definir los miembros de la clase, que son los elementos que forman parte de la clase. Los miembros de una clase pueden ser:

- Campos: son variables que almacenan los datos o el estado de la clase. Se pueden declarar usando un modificador de acceso, un tipo de dato y un nombre. Por ejemplo: `private string nombre;`
- Propiedades: son mecanismos que permiten acceder o modificar los campos de la clase de forma controlada. Se pueden declarar usando un modificador de acceso, un tipo de dato, un nombre y unos accesores get y set. Por ejemplo: `public string Nombre { get; set; }`
- Métodos: son funciones que realizan las acciones o el comportamiento de la clase. Se pueden declarar usando un modificador de acceso, un tipo de retorno, un nombre y unos parámetros. Por ejemplo: `public void Saludar() { Console.WriteLine("Hola"); }`
- Constructores: son métodos especiales que se invocan al crear una instancia de la clase. Se pueden declarar usando el nombre de la clase y unos parámetros. Por ejemplo: `public Persona(string nombre) { this.nombre = nombre; }`
- Otros miembros: como eventos, delegados, enumeraciones, etc.

Los objetos son instancias o ejemplares de una clase, es decir, son copias concretas que se crean a partir del molde o la definición que proporciona una clase. Los objetos se pueden crear usando la palabra clave new seguida del nombre de la clase y unos parámetros entre paréntesis. Por ejemplo:

```csharp
// Crear un objeto de la clase Persona con el nombre "Juan"
Persona juan = new Persona("Juan");
```

Los objetos tienen acceso a los miembros de la clase a través del operador punto (.), que permite acceder o invocar a los campos, propiedades, métodos u otros miembros de la clase. Por ejemplo:

```csharp
// Acceder a la propiedad Nombre del objeto juan
string nombre = juan.Nombre;

// Invocar al método Saludar del objeto juan
juan.Saludar();
```

Las clases y los objetos tienen algunas ventajas, como:

- Permiten modelar entidades o conceptos del mundo real con sus atributos y comportamientos.
- Facilitan la abstracción, el encapsulamiento, la herencia y el polimorfismo, que son los principios básicos de la programación orientada a objetos.
- Favorecen la reutilización, el mantenimiento y la extensibilidad del código.

Sin embargo, las clases y los objetos también tienen algunas desventajas, como:

- Requieren un mayor nivel de diseño y planificación antes de implementar el código.
- Pueden generar una mayor complejidad y acoplamiento entre las diferentes clases y objetos del programa.
- Pueden consumir más recursos de memoria y procesamiento que otros tipos de datos.

En conclusión, las clases y los objetos son dos formas de organizar y manipular datos en C#, siguiendo el paradigma de la programación orientada a objetos. Las clases son las estructuras que definen las características y el comportamiento de una entidad o concepto, mientras que los objetos son las instancias o ejemplares que se crean a partir de una clase. La elección entre uno u otro dependerá de las necesidades y preferencias de cada programador.  😊

## Herencia y polimorfismo

Estos son dos conceptos clave de la programación orientada a objetos, que permiten definir relaciones entre clases y aprovechar sus características y comportamientos. En esta sección, veremos qué son la herencia y el polimorfismo, cómo se implementan y usan en C#, y qué ventajas y desventajas tienen cada uno.

La herencia es el mecanismo que permite crear una clase derivada a partir de una clase base, de forma que la clase derivada hereda los miembros de la clase base y puede reutilizarlos, modificarlos o añadir nuevos. La herencia se puede crear usando el operador de dos puntos (:) seguido del nombre de la clase base después del nombre de la clase derivada. Por ejemplo:

```csharp
// Crear una clase base llamada Animal
class Animal
{
    // Miembros de la clase base
}

// Crear una clase derivada llamada Perro que hereda de Animal
class Perro : Animal
{
    // Miembros de la clase derivada
}
```

La herencia tiene algunas ventajas, como:

- Permite reutilizar el código existente en la clase base, evitando la duplicación y facilitando el mantenimiento.
- Permite establecer una jerarquía de clases que refleja la relación entre las entidades o conceptos del dominio del problema.
- Permite aplicar el principio de sustitución de Liskov, que dice que un objeto de una clase derivada puede ser usado en cualquier lugar donde se espera un objeto de la clase base.

Sin embargo, la herencia también tiene algunas desventajas, como:

- Puede generar un acoplamiento fuerte entre la clase base y la clase derivada, lo que dificulta el cambio o la extensión de ambas clases.
- Puede violar el principio de responsabilidad única, si la clase derivada asume más responsabilidades que las que le corresponden por su naturaleza.
- Puede ocultar o enmascarar el comportamiento de la clase base, si la clase derivada lo modifica o invalida.

El polimorfismo es el mecanismo que permite que un objeto pueda comportarse de diferentes formas según su tipo en tiempo de ejecución. El polimorfismo se puede implementar usando métodos virtuales o abstractos en la clase base, que pueden ser sobrescritos o implementados por las clases derivadas. Por ejemplo:

```csharp
// Crear una clase base abstracta llamada Figura
abstract class Figura
{
    // Definir un método abstracto llamado Dibujar
    public abstract void Dibujar();
}

// Crear una clase derivada llamada Circulo que hereda de Figura
class Circulo : Figura
{
    // Implementar el método Dibujar para dibujar un círculo
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un círculo");
    }
}

// Crear una clase derivada llamada Triangulo que hereda de Figura
class Triangulo : Figura
{
    // Implementar el método Dibujar para dibujar un triángulo
    public override void Dibujar()
    {
        Console.WriteLine("Dibujando un triángulo");
    }
}
```

El polimorfismo tiene algunas ventajas, como:

- Permite tratar a los objetos de diferentes clases derivadas como si fueran de la misma clase base, usando una referencia o un parámetro del tipo de la clase base.
- Permite invocar al método adecuado según el tipo real del objeto en tiempo de ejecución, usando el operador punto (.) sobre la referencia o el parámetro del tipo de la clase base.
- Permite definir una interfaz común para las clases derivadas, que deben cumplir con el contrato establecido por la clase base.

Sin embargo, el polimorfismo también tiene algunas desventajas, como:

- Puede generar confusión o errores si no se respeta el contrato establecido por la clase base o si se cambia el comportamiento esperado por las clases derivadas.
- Puede ocasionar una pérdida de rendimiento al tener que resolver dinámicamente qué método invocar en tiempo de ejecución.
- Puede requerir un mayor conocimiento y cuidado por parte del programador para usarlo correctamente y evitar problemas.

En conclusión, la herencia y el polimorfismo son dos conceptos clave de la programación orientada a objetos, que permiten definir relaciones entre clases y aprovechar sus características y comportamientos. La herencia permite crear una clase derivada a partir de una clase base, de forma que la clase derivada hereda los miembros de la clase base y puede reutilizarlos, modificarlos o añadir nuevos. El polimorfismo permite que un objeto pueda comportarse de diferentes formas según su tipo en tiempo de ejecución, usando métodos virtuales o abstractos en la clase base, que pueden ser sobrescritos o implementados por las clases derivadas. La elección entre uno u otro dependerá de las necesidades y preferencias de cada programador. 😊

## Excepciones y manejo de errores.

Estos son dos conceptos relacionados con el control de excepciones, que es una técnica que permite manejar situaciones inesperadas o anómalas que ocurren durante la ejecución de un programa. En esta sección, veremos qué son las excepciones y el manejo de errores, cómo se implementan y usan en C#, y qué ventajas y desventajas tienen cada uno.

Las excepciones son objetos que representan un error o una condición excepcional que impide que el programa continúe con su flujo normal. Las excepciones se pueden generar por el sistema, por las bibliotecas o por el código de la aplicación, usando la palabra clave throw. Por ejemplo:

```csharp
// Generar una excepción de tipo DivideByZeroException
throw new DivideByZeroException("No se puede dividir por cero");
```

Las excepciones se derivan de la clase base System.Exception, que tiene algunas propiedades y métodos que proporcionan información sobre el error, como:

- Message: devuelve un mensaje que describe el error.
- StackTrace: devuelve una cadena que contiene la traza de la pila donde se produjo el error.
- InnerException: devuelve la excepción interna que causó el error, si la hay.
- Data: devuelve un diccionario que contiene datos adicionales sobre el error.

Las excepciones tienen algunas ventajas, como:

- Permiten separar el código normal del código de manejo de errores, mejorando la legibilidad y la estructura del programa.
- Permiten propagar el error a través de la pila de llamadas hasta encontrar un manejador adecuado, evitando que el programa se cierre abruptamente.
- Permiten proporcionar información detallada sobre el error, facilitando su depuración y solución.

Sin embargo, las excepciones también tienen algunas desventajas, como:

- Pueden afectar al rendimiento del programa si se usan con demasiada frecuencia o para controlar el flujo lógico del programa.
- Pueden ocultar o enmascarar errores si no se capturan o se lanzan correctamente, dificultando su identificación y corrección.
- Pueden generar inconsistencias o pérdidas de recursos si no se liberan o restauran adecuadamente los recursos afectados por el error.

El manejo de errores es el proceso de detectar, capturar y tratar las excepciones que se producen en un programa. El manejo de errores se puede implementar usando las palabras clave try, catch y finally, que forman parte de la instrucción try-catch-finally. Por ejemplo:

```csharp
try
{
    // Código que puede generar una excepción
}
catch (TipoDeExcepcion ex)
{
    // Código que se ejecuta si se produce una excepción del tipo especificado
}
finally
{
    // Código que se ejecuta siempre después del bloque try o catch
}
```

El manejo de errores tiene algunas ventajas, como:

- Permite controlar las excepciones y evitar que el programa se cierre inesperadamente.
- Permite recuperar el estado del programa o realizar acciones correctivas ante un error.
- Permite informar al usuario o al desarrollador sobre el error y sus posibles causas o soluciones.

Sin embargo, el manejo de errores también tiene algunas desventajas, como:

- Requiere un mayor nivel de diseño y planificación para implementar un manejo de errores adecuado y eficaz.
- Requiere seguir unas buenas prácticas y unos principios para evitar errores comunes o malas prácticas en el manejo de errores.
- Requiere tener un conocimiento previo sobre los tipos de excepciones que pueden producirse y cómo controlarlos adecuadamente.

En conclusión, las excepciones y el manejo de errores son dos conceptos relacionados con el control de excepciones, que es una técnica que permite manejar situaciones inesperadas o anómalas que ocurren durante la ejecución de un programa. Las excepciones son objetos que representan un error o una condición excepcional que impide que el programa continúe con su flujo normal. El manejo de errores es el proceso de detectar, capturar y tratar las excepciones que se producen en un programa. La elección entre uno u otro dependerá de las necesidades y preferencias de cada programador. 


### Referencias.

- [APA Formatting and Style Guide (7th Edition) - Purdue OWL®](https://owl.purdue.edu/owl/research_and_citation/apa_style/apa_formatting_and_style_guide/index.html)
- [Arreglos bidimensionales c# ejemplos | Colecciones y Arreglos | Programando en C#](https://www.youtube.com/watch?v=dXchlGBS0FQ)
- [Arreglos en C# - MiLibreta.com.mx](http://galvez.milibreta.com.mx/UAS/Lenguajes/C%20sharp/11.-Arreglos%20en%20C%20sharp.pdf)
- [Arreglos y listas | Curso de fundamentos de C#](https://www.youtube.com/watch?v=Rqt-claFn0U)
- [Clases y objetos - Portal Académico CCH](https://portalacademico.cch.unam.mx/cibernetica2/principios-programacion-orientada-a-objetos/clases-y-objetos)
- [Clases y objetos en C# - Desarrollo Web](https://desarrolloweb.com/articulos/clases-objetos-c-sharp)
- [Clases y objetos: tutorial de aspectos básicos de C# - C#](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/tutorials/classes)
- [Colección de datos: tutorial interactivo de introducción a C#](https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/list-collection)
- [Colecciones - C# | Microsoft Learn](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/collections)
- [Colecciones y Arreglos | Programando en C#](https://www.youtube.com/watch?v=55lvMBZaM0I)
- [Curso C#. Métodos I. Vídeo 9](https://www.youtube.com/watch?v=FTJoQ71r3a4)
- [{ Diferencias entre CLASE y OBJETO en Programación } - GameDevTraum](https://gamedevtraum.com/es/programacion-informatica/programacion-orientada-a-objetos/diferencia-entre-clase-y-objeto/)
- [Diferencias entre métodos, procedimiento, función, para que sirven cada ...](https://es.stackoverflow.com/questions/7403/diferencias-entre-m%C3%A9todos-procedimiento-funci%C3%B3n-para-que-sirven-cada-uno-y-co)
- [Duda entre función y método en C# - Stack Overflow en español](https://bing.com/search?q=C%23+m%c3%a9todos+y+funciones)
- [Funciones (Métodos) en C Sharp: Funciones con Parámetros ✅ | Curso C# 28](https://www.youtube.com/watch?v=jt6XLUB6_l8)
- [Funciones y métodos en C# - Disco Duro de Roer](https://www.discoduroderoer.es/funciones-y-metodos-en-c-sharp/)
- [Funciones y métodos en C#. ⭐ Aprende informática desde cero.](https://www.clasesdeinformaticaweb.com/csharp/metodos-y-funciones-en-c/)
- [Funciones y métodos en C - Parzibyte's blog](https://parzibyte.me/blog/2018/09/20/funciones-y-metodos-en-c/)
- [Guía práctica para trabajar con Arrays y colecciones en C#](https://estradawebgroup.com/Post/Guia-practica-para-trabajar-con-Arrays-y-colecciones-en-C/20641)
- [How to cite a website in APA Style | Format & Examples - Scribbr](https://www.scribbr.com/apa-examples/website/)
- [How to cite a website | MLA, APA & Chicago Examples - Scribbr](https://www.scribbr.com/citing-sources/cite-a-website/)
- [Métodos y funciones en C#](http://bit.ly/2vtrUg9)
- Origen: Conversación con Bing, 15/10/2023
- [Polimorfismo - C# | Microsoft Learn](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/object-oriented/polymorphism)
- [Uso de List<T>: tutorial de introducción a C# - C#](https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections)

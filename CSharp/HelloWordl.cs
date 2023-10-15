using System;

// Indica el contexto al que pertenece la clase y objetos que se crean dentro de este espacio
namespace CSharpHelloWorld
{
    //Creamos una clase
    class HelloWorld
    {
        //Main genera un punto de entrada a la clase HelloWorld
        static void Main(string[] args)
        {
            Console.WriteLine("Mis primeros pasos en CSharp");
            Console.WriteLine();//Imprime por consola un espacio entre las líneas
            Console.WriteLine("Aprendiendo la sintaxis de CSharp");

            /*
            CSharp es un lenguaje fuertemente tipado, por lo cual es
            muy importante conocer tanto los tipos de datos básicos
            como primitivos y su furmos de declaración en el código
            */

            //Tipo de dato string (Cadenas de texto)

            /*Iniciamos con la palabra reservada string, seguido del nombre de
            la variable, concluímos la declaración con ; y despues la podemos mandar imprimir por consola.
            */
            Console.WriteLine();
            string CadenaDeTexto ="Hola, esto es una cadena de texto";
            CadenaDeTexto = "Aquí cambió la cadena de texto";
            Console.WriteLine(CadenaDeTexto);

            // Declaración de una variable entera
            int numero = 10;
            Console.WriteLine(numero);

            Console.WriteLine( );

            // Declaración de una variable de tipo cadena
            string texto = "Hola, esto es una cadena de texto";
            Console.WriteLine(texto);

            Console.WriteLine( );

            // Declaración de una variable booleana
            bool esVerdadero = true;
            Console.WriteLine(esVerdadero);

            Console.WriteLine( );

            // Declaración de una variable de tipo decimal
            decimal precio = 19.99m;
            Console.WriteLine(precio);

            /*
            Concatenación de cadenas: Puedes unir dos cadenas utilizando el operador de concatenación (+) o el método Concat() de la clase String.
            */
            string cadena1 = "Hola";
            string cadena2 = "Mundo";
            string resultado = cadena1 + " " + cadena2;
            Console.WriteLine(resultado);
            // Uso del método Concat()
            string resultado2 = string.Concat(cadena1, " ", cadena2);
            Console.WriteLine(resultado2);
            Console.WriteLine();

            /*
            Obtener la longitud de una cadena: Puedes utilizar la propiedad Longitud para obtener la cantidad de caracteres en una cadena.
            */
            string cadena = "Hola Mundo";
            int longitud = cadena.Length;
            Console.WriteLine(longitud);
            Console.WriteLine();

            /*
            Buscar una subcadena: Puedes utilizar el método IndexOf() para encontrar la posición de una subcadena dentro de otra cadena.
            */
            string cadena3 = "Hola Mundo";
            int posicion = cadena3.IndexOf("Mundo");
            Console.WriteLine(posicion);
            Console.WriteLine();

            /*
        Operaciones con datos numéricos:
        Operaciones aritméticas: Puedes realizar operaciones matemáticas básicas como suma, resta, multiplicación y división utilizando los operadores correspondientes.
        */
        int numero1 = 10;
        int numero2 = 5;

        int suma = numero1 + numero2; // suma = 15
        Console.WriteLine(suma);
        Console.WriteLine( );

        int resta = numero1 - numero2; // resta = 5
        Console.WriteLine(resta);
        Console.WriteLine( );

        int multiplicacion = numero1 * numero2; // multiplicacion = 50
        Console.WriteLine(multiplicacion);
        Console.WriteLine( );

        int division = numero1 / numero2; // division = 2
        Console.WriteLine(division);
        Console.WriteLine( );

                /*
        Conversión de tipos: Puedes convertir un tipo de dato numérico a otro utilizando métodos como Parse() o TryParse().
        */
        string conversionTexto = "123";
        int conversionNumero = int.Parse(conversionTexto); // conversionNumero = 123
        Console.WriteLine(conversionNumero);
        Console.WriteLine( );

        string conversionTexto2 = "abc";
        bool conversionExitosa = int.TryParse(conversionTexto2, out int conversionNumero2); // conversionExitosa = false, conversionNumero2 = 0
        Console.WriteLine(conversionExitosa);
        Console.WriteLine( );



        }
    }

}
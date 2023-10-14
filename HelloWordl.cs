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
        }
    }

}
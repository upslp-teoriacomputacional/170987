/*
Teoria Computacional
Programa 4 "Operaciones con Cadenas"
Alumna: Maria de los Angeles Zapata Vazquez
Matricula:  170987
*/
using System;
using System.Globalization;
namespace PeracionesCadenas {
    class Program {
        static void Main(string[] args) {
            string singQuotes = "'C# in single quotes'";
            Console.WriteLine(singQuotes);
		//Declaro todas las cadenas que utilizre
		string mensaje = "Hello, Python!";
 		string Texto = "PYTHON";
            	string doubQuotes = "C# in double quotes";
 		string mensaje1 = "    Welcome C#.  ";
		string mensaje2 = "Welcome C#!";
 		string mensaje4 = "Welcome C#!    ";
		string mensaje5 = "C# with dotnettechpoint.com";
		string mensaje6 = "C#, tutorials, with, dotnettechpoint.com";
		string mensaje7 = "c# tutorial with dotnettechpoint.com";
		string mensaje8 = "C# Tutorials";
            Console.WriteLine(doubQuotes);
            Console.WriteLine(mesaje[7]);
            //Muestra caracter en la posicion 4
            Console.WriteLine(Texto.Substring(4,1));
            //Muestra el caracter que ocupa el lugar la posicion cuatro comenzando por el final de la cadena
            Console.WriteLine(Texto.Substring(Texto.Length-4,1));
            //Muestra 3 caracteres a partir del que ocupa el lugar numero 7
            Console.WriteLine(mensaje.Substring(7, 3));
            //Elimna espacios entre cadenas
            Console.WriteLine(mensaje1.TrimStart());
            //Minusculas
            Console.WriteLine(mensaje2.ToLower())
            //Mayusculas
            Console.WriteLine(mensaje2.ToUpper());
            //Length Method
            Console.WriteLine(Convert.ToString(mensaje4.Length));
            //Remplaza una cadena indicada por otra indicada
            Console.WriteLine(mensaje5.Replace("C#","Learn C#"));
            //Split Method
            char[] separador = {','};
            string[] palabra = mensaje6.Split(separador);
            Console.Write("[ ");
            foreach (string palabra in words) {
                Console.Write("'{0}' ", palabra);
            }
            
            //Cambiar una letra a mayuscula 
            Console.WriteLine(char.ToUpper(mensaje7[0]) + mensaje7.Substring(1));
		//Cuenta letra indicados en este caso la letra "t" en una cadena
            int contador = 0;
            for(int i=0; i<mensaje7.Length; i++) {
                if (mensaje7[i].Equals('t')) {
                    contador++;
                }
            } 
		//Muestra el numero de letras indicado
            Console.WriteLine(contador);

            //Find Method
            Console.WriteLine(mensaje7.IndexOf("with"));
            //Uninion de dos strings
            for(int i=0; i<mensaje8.Length; i++) {
                Console.Write(mensaje7[i]+ " ");
            }

        }
    }
}
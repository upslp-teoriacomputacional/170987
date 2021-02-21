/*
* Teroia Compitacional
* Programa: Validacion de datos
* Alumna: Maria de los Angeles Zapata Vazquez
* Matricula: 170987
* El objetivo del funcionamiento de este programa es que valide una cadena de
* caracteres ya sean de a-Z y del  0-9
*/
using System; 
using System.Text.RegularExpressions;
namespace funcionValida {
	static void Main(string[] args) {

		//Se define el rango de elementos que deberan ser validados en la cadena
		string pattern = "[0-9a-z]";
		//Utilizo un do-while para que el programa ternine hasta que se ingrese la cadena correcta.
		do{
		//Instrucciones mostradas en pantalla
			Console.Write("Ingresa una cadena que solo incluya letras y numeros");
			//La informacion ingresada se guarda en un variable, despues en la misma declaracion se 
			//evelua la cadena, y de auerdo el valor true o false de muestra un mensaje.
			bool cadena = reg.IsMatch(Console.ReadLine());
			if (cadena) {
				//Muestro mensaje
				Console.WriteLine("Cadena Correcta");
			}
			else { 
				//Muestro mensaje
			Console.WriteLine("Cadena incorrecta");
			} 
		}while(cadena!=true)
	}

}
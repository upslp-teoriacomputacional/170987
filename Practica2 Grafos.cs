/*
 Universidad Politecnica de San Luis Potosi
Teoria Computacional
Practica 2:Teoria de Grafos
Alumna:Maria de los Angeles Zapata Vazquez
Matricula:170987
Lenguaje: C#
 */
using System;
namespace Practica2
{
    class Program
    {
        private static object pro;

        static void Main(string[] args)
        {
            /*Construccion de matriz la cual contiene 
            los nodos que tiene  un arista en comun.
            */

            char[,] grafo=new char[2,10];
            grafo['a', 'c']= (char)1;
            grafo['b', 'c'] = (char)1;
            grafo['b', 'e'] = (char)1;
            grafo['c', 'd'] = (char)1;
            grafo['c', 'e'] = (char)1;
            grafo['c', 'a'] = (char)1;
            grafo['c', 'b'] = (char)1;
            grafo['e', 'b'] = (char)1;
            grafo['d', 'c'] = (char)1;
            grafo['e', 'c'] = (char)1;
            int NoVerticesGrafo = grafo.GetLength(0);
		//Muestro el numero de vertices que tiebe el grafo
            Console.WriteLine("Numero de vertices"+NoVerticesGrafo);
        }
        public void NumeroAristas(char[,] grafo)
        {
            int aristas = 0;
		//Utilizo dos ciclos for anidados para poder contar las aristas 
            for (int i = 0; i < grafo.GetLength(0); i++)
            {
                for (int f = 0; f < grafo.GetLength(0); f++)
                {
                    int num = grafo[i, f];
                    if (num == 0)
                    {
                        aristas++;
                    }
                }
            }
	//Muestro el numero de con las que cuenta el grafo
            Console.WriteLine("Numero de aristas" + aristas);
        }
    }
}

/******************************************************************************
Practica 2
Programa para mostrar las difentes operaciones con arreglos como en matematicas
Lenguaje C++
Alumna: Maria de los Ángeles Zapata Vazquez 
Matricula: 170987
*******************************************************************************/
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <iostream>
int main()
{
    /*Creo arreglos*/
    int c[5];
    int it, iter;
    //Defino valores de arreglos
   int A[]={1,2,3,4,5};
    int B[]={3,4,5,6,7};
    //Mostrar valores de cada arreglo
    printf("Conjunto A");
     int limiteA=(sizeof(A)/sizeof(A[0]));
     for(int i=0; i< limiteA; i++)
     {
         cout<<A[i]<<endl;
     }
     printf("Conjunto B");
     int limiteB=(sizeof(B)/sizeof(B[0]));
     for(int z=0; z< limiteB; z++)
     {
    
         cout<<B[z]<<endl;
     }
    //Eliminar un elemento=2 del conjunto A y vuelve a mostrar el conjunto
    A.erase(A.begin()+1);
    for(int i=0; i< limiteA; i++)
     {
         cout<<A[i]<<endl;
     }
     //Eliminar todos los elementos del conjunto A
     A.erase(A.begin()+4);
     printf("Conjunto A, vacio");
     //Asignar los elementos del conjunto  B al conjunto A
     for(int z=0; z< limiteB; z++)
     {
         B[z]=A[z];
     }
     //Inserta un elemento al conjunto B
     it=B.begin();
     it=B.insert(it,987);
     iter=A.begin();
     iter=A.insert(it,989);
     //Union del conjunto A Y B
      for(int p=0; p< limiteB; p++)
     {
         if(A[p]==B[p]){
             cout<<A[p]<<endl;
         }else{
             cout<<B[p]<<endl;
             cout<<A[p]<<endl;
         }
     }
     //Inteseccion deL Conjunto A y B 
      for(int p=0; p< limiteB; p++)
     {
         if(A[p]==B[p]){
             cout<<A[p]<<endl;
         }
     }
     //Diferencia del conjunto A y B 
     for(int p=0; p< limiteB; p++)
     {
         if(A[p]!=B[p]){
             cout<<A[p]<<endl;
              cout<<B[p]<<endl;
             
         }
     }
     
    return 0;
}

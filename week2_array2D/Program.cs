﻿/*
double[,] temperaturas = new double[4, 7];

temperaturas[0, 0] = 12; temperaturas[0, 1] = 12000; temperaturas[0, 2] = 40000; temperaturas[0, 3] = 65; temperaturas[0, 4] = 19; temperaturas[0, 5] = 24; temperaturas[0, 6] = 10;
temperaturas[1, 0] = 10; temperaturas[1, 1] = 30; temperaturas[1, 2] = 70; temperaturas[1, 3] = 10; temperaturas[1, 4] = 60; temperaturas[1, 5] = 70; temperaturas[1, 6] = 10;
temperaturas[2, 0] = 10; temperaturas[2, 1] = 75; temperaturas[2, 2] = 74; temperaturas[2, 3] = 10; temperaturas[2, 4] = 18; temperaturas[2, 5] = 80; temperaturas[2, 6] = 80;
temperaturas[3, 0] = 80; temperaturas[3, 1] = 54; temperaturas[3, 2] = 79; temperaturas[3, 3] = 10; temperaturas[3, 4] = 66; temperaturas[3, 5] = 65; temperaturas[3, 6] = 10;

Console.WriteLine("           lunes       martes      miercoles   jueves      viernes     sabados     domingo");
Console.WriteLine();

int week = 1;
for (int i = 0; i < temperaturas.GetLength(0); i++)
{
    
    Console.Write($"semana: {week}  ");
    week++;

    for (int j = 0; j < temperaturas.GetLength(1); j++)
    {
         
       
         if(temperaturas[i, j] >= 1000 )
        {
            Console.Write($"|{temperaturas[i, j]}|     ");
        } 
         else if (temperaturas[i, j] >= 10000)
        {
            Console.Write($"|{temperaturas[i, j]}|");
        }
        else
        {
            Console.Write($"|{temperaturas[i, j]}|        ");
        }
        
        
        
    }
}
*/

   

Console.WriteLine();


int i, j, filas;
Console.WriteLine("Ingresa el numero de filas");
filas = Convert.ToInt32(Console.ReadLine());

int spaces = filas;

for (i = 1; i <= filas; i++)
{
    for (int k = spaces; k > 0; k--)
    {
        Console.Write("-");  
    }
    spaces--;
    for (j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    
    Console.Write("\n");
}


Console.WriteLine("Se acabo el bucle");

/*
 * 1
 * 1 2
 * 1 2 3
 * 1 2 3 4
 */

int[] arreglo = { 44, 44, 32, 55 };
var copy = arreglo;


int numeroRepetido = 0;

for (int k = 0; k < arreglo.Length; k++)
{
    
    for (int m = 0; m < copy.Length; m++)
    {
        if (arreglo[k] == copy[m])
        {
            numeroRepetido++;
            
        }
        else
        {
            Console.WriteLine("numeros repetidos " + numeroRepetido);
            return;
        }
        
    }

}


using System;
using exerciciosFixacao.exercicioStruct;

namespace exerciciosFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            //exercício Struct
            Point p;                //não precisa de new, pois é um tipo valor...
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();        //...mas aceita
            Console.WriteLine(p);
            */

            //exercício Matriz
            double[,] mat;              //declarando uma matriz
            mat = new double[2, 3];     //instanciando uma matriz de 2 linhas e 3 colunas
            Console.WriteLine(mat.Length);          //quantos elementos a matriz tem
            Console.WriteLine(mat.Rank);            //quantas linhas tem
            Console.WriteLine(mat.GetLength(0));    //tamanho da primeira dimensao da matriz (==Rank)
            Console.WriteLine(mat.GetLength(1));    //tamanho da segunda dimensao da matriz

        }


    }
}

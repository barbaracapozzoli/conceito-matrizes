using System;

class Program
{
       static void Main()
    {
        // Fazer um programa para ler dois números inteiros M e N, depois ler uma matriz de M linhas e N colunas contendo números inteiros.
        // Em seguida, mostrar na tela a matriz lida.

        int M, N; // M linhas e N colunas
        int[,] A; // Matriz A de M linhas e N colunas


        string[] s1 = Console.ReadLine().Split(' '); // Vetor de string com os valores de M e N
        M = int.Parse(s1[0]); // Acessar o primeiro elemento do vetor s1 e converter para inteiro 
        N = int.Parse(s1[1]); // Acessar o segundo elemento do vetor s1 e converter para inteiro
        A = new int[M, N]; // Instanciar a matriz A com M linhas e N colunas

        for (int i=0; i<M; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            for(int j=0; j<N; j++)
            {
                A[i, j] = int.Parse(s[j]);
            }
        }

        for (int i=0; i<M; i++)
        {
            for(int j=0; j<N; j++)
            {
                Console.Write(A[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();

    }
}
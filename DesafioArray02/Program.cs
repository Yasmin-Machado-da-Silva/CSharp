﻿int[] vetor1 = new int[10];
int[] vetor2 = new int[10];
int[] vetorIntercalado = new int[20];

Console.WriteLine("Digite 10 números para o primeiro vetor:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Vetor 1 - Elemento {i + 1}: ");
    vetor1[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite 10 números para o segundo vetor:");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Vetor 2 - Elemento {i + 1}: ");
    vetor2[i] = int.Parse(Console.ReadLine());
}

for (int i = 0, j = 0; i < 10; i++, j += 2)
{
    vetorIntercalado[j] = vetor1[i];
    vetorIntercalado[j + 1] = vetor2[i];
}

Console.WriteLine("Vetor intercalado:");
for (int i = 0; i < 20; i++)
{
    Console.Write($"{vetorIntercalado[i]} ");
}

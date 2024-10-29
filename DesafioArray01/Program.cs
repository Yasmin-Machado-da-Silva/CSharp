int[] numeros = new int[6];
int Pares = 0, Impares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite o {i + 1}° número:");
    int numeroDigitado = int.Parse(Console.ReadLine());
    numeros[i] = numeroDigitado;

    if (numeroDigitado % 2 == 0)
    {
        Pares++;
    }
    else
    {
        Impares++;
    }
}

Console.WriteLine($"Quantidade de números pares: {Pares}");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i] );
    }
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine($"Quantidade de números ímpares: {Impares}");
for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i] );
    }
}
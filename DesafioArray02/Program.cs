int[] arrayNumeros1 = {50, 90, 100, 499, 1257, 56, 589, 90, 30, 201};
int[] arrayNumeros2 = {999, 456, 898, 1, 5, 7, 80, 2, 3, 2010};

Console.WriteLine("Digite 10 números para o primeiro vetor:");
for (int i = 0; i < arrayNumeros1.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(arrayNumeros1[i]);
    }
    else
    {
        Console.WriteLine(arrayNumeros2[i]);
    }
}

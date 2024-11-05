string [] frutas = {"Melancia", "Carambola", "Maracuja", "Morango", "Limao", "Jabuticaba", "Abacate", "Kiwi", "Acerola", "Pinha", "Lichia", "Pitaya", "Pessego", "Banana"};

Console.WriteLine($"Sua sacola contem {frutas.Length} frutas!");

foreach (string f in frutas)
{
    Console.WriteLine($"{f}, "); 
}

Console.WriteLine();

int[] num = { 1,2,3,4,5,6,7,8,9,10 };


foreach (int n in num)
{
    Console.WriteLine($"O Dobro dos numeros sao : {n*2}");
}
Console.WriteLine("");
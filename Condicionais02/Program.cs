Console.WriteLine
(@"
#---------------------------------------#
|               BEM-VINDO               |
#---------------------------------------#
|    Este é o programa de futbol, res-  |
|  ponda aos dados pedidos abaixo e     |
|  veja seu resultado:                  |
#---------------------------------------#
");

Console.WriteLine($"Quantos gols tiveram o time1?");
float golsTime1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos gols tiveram o time2?");
float golsTime2 = float.Parse(Console.ReadLine()!);

if (golsTime1 > golsTime2)
{
    Console.WriteLine($"time 1venceu!");
}
else if (golsTime2 > golsTime1)
{
    Console.WriteLine($"time 2 venceu!");
}
else
{
    Console.WriteLine("O jogo terminou empatado!");
}

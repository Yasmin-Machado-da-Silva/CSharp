Console.WriteLine
(@"
#---------------------------------------#
|               BEM-VINDO               |
#---------------------------------------#
|    Este é o programa de salario, res- |
|  ponda aos dados pedidos abaixo e     |
|  veja seu resultado:                  |
#---------------------------------------#
");


Console.WriteLine($"Qual seu salario: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Qual seu orcamento: ");
float orcamento = float.Parse(Console.ReadLine()!);

if (salario > orcamento)
{
Console.WriteLine($"Voce nao estourou o orcamento");

}else{
Console.WriteLine($"Voce estourou o orcamento");
}
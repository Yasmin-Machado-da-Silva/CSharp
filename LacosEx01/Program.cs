Console.WriteLine
(@"
#---------------------------------------#
|               BEM-VINDO               |
#---------------------------------------#
|       Este é o programa contador      |
|              de pessoas               |
#---------------------------------------#
");

int qtdMulher = 0;
int qtdHomem = 0;
int qtdEsportes = 0;
int qtdEsportesNgosta = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int qtdDeEntrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f"){
        qtdMulher++;
    }
    else {
        qtdHomem++;
    }

    Console.WriteLine($"Voce gosta de esportes? s/n");
    string Esportes =Console.ReadLine();

    if (Esportes == "s")
    {
        qtdEsportes++;
    }else {

        qtdEsportesNgosta ++;
    }
}
float percentual = (100 / qtdDeEntrevistados) * qtdEsportes;

Console.WriteLine($"Quantidade de mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de homens: {qtdHomem}");
Console.WriteLine($"Total entrevistados: {qtdMulher + qtdHomem}");
Console.WriteLine($"Total de pessoas que gostam de esporte: {qtdEsportes}");
Console.WriteLine($"Total de pessoas que nao gostam de esporte: {qtdEsportesNgosta}");
Console.WriteLine($"Percentua; de pessoas que gostam de esporte: {percentual}%");

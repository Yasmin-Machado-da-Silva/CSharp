// [ ] DesafioLaco01: Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// O número de pessoas que responderam SIM;
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados

Console.WriteLine
(@"
#---------------------------------------#
|               BEM-VINDO               |
#---------------------------------------#
|       Este é o programa contador      |
|              da empresa               |
#---------------------------------------#
");

int qtdDeEntrevistados = 10;
int qtdMulher = 0;
int qtdHomem = 0;
int qtdProduto = 0;
int qtdProdutoNgosta = 0;
int pessoas = 0;
int pessoasqNgostaram = 0;




for (int i = 1; i <= qtdDeEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "f"){
        qtdMulher++;
        pessoas++;
    }
    else {
        qtdHomem++;
        pessoasqNgostaram++;
    }

    Console.WriteLine($"Voce gostou do produto? s/n");
    string produto =Console.ReadLine();

    if (produto == "s")
    {
        qtdProduto ++;
    }else {
        
        qtdProdutoNgosta ++;
    }
}
        float percentual = (100 / qtdDeEntrevistados) * qtdProdutoNgosta;

Console.WriteLine($"Pessoas que gostaram: {pessoas}");
Console.WriteLine($"Pessoas que n gostaram: {pessoasqNgostaram}");
Console.WriteLine($"Mulheres que gostaram: {qtdMulher}");
Console.WriteLine($"Percentual de homens q nao gostaram : {percentual}%");

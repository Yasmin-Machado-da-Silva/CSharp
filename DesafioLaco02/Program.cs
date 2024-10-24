// [ ] DesafioLaco02: Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// Total de Homens;
// Total de Mulheres;
// Média de idade dos Homens;
// Média de idade das mulheres.

int qtdHomens = 0; 
int qtdMulheres = 0; 
int somaIdadeHomens = 0;
int somaIdadeMulheres = 0;

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"Pessoa {i}");

    string sexo = "";
    // operadores lógicos:
    // &&
    // ||
    // !
    // operadores relacionais:
    // >
    // <
    // >=
    // <=
    // ==
    // !=
    while (sexo != "m" && sexo != "f")
    {
        Console.WriteLine("Sexo (m/f):");
        sexo = Console.ReadLine();
    }

    Console.WriteLine("Idade:");
    int idade = int.Parse(Console.ReadLine());

    if (sexo == "m")
    {
        qtdHomens++;
        // += acumulador
        // 59               
        somaIdadeHomens += idade;
    }
    else
    {
        qtdMulheres++;
        somaIdadeMulheres += idade;
    }
}

float mediaIdadeHomens = somaIdadeHomens / qtdHomens;
float mediaIdadeMulheres = somaIdadeMulheres / qtdMulheres;

Console.WriteLine($"\nTotal de homens: {qtdHomens}");
Console.WriteLine($"Total de mulheres: {qtdMulheres}");
Console.WriteLine($"Média de idade dos homens: {mediaIdadeHomens:F1} anos");
Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:F1} anos");

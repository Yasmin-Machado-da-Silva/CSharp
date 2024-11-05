using System;
using AtividadeClasses;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("*** Programa Fábrica de Carros! ***");

        Veiculo bmwX6 = new Veiculo();

        Console.WriteLine("Qual é a marca do carro?");
        bmwX6.marca = Console.ReadLine();

        Console.WriteLine("Qual é o modelo?");
        bmwX6.modelo = Console.ReadLine(); 

        Console.WriteLine("Qual é a cor?");
        bmwX6.cor = Console.ReadLine();

        Console.WriteLine("Qual é a potência?");
        bmwX6.potencia = Console.ReadLine();

        Console.WriteLine("Quantas portas?");
        bmwX6.qtdPortas = int.Parse(Console.ReadLine());

        Console.WriteLine($"Carro: {bmwX6.marca} {bmwX6.modelo}, Cor: {bmwX6.cor}, Potência: {bmwX6.potencia}, Portas: {bmwX6.qtdPortas}");

        bmwX6.Ligar();
    }
}

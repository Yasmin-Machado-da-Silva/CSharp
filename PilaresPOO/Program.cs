using PilaresPOO.Classes.Aprendizagem;

Pessoa Yaya = new Pessoa();
Yaya.Nome = "Yaya";

Console.WriteLine($"{Yaya.Nome} Nasceu com {Yaya.Idade} anos");

//dados do professor
Professor sam = new Professor(432342);
sam.Nome = "Samanata";
sam.Idade = 22;

//dados do aluno
Aluno isaacBorges = new Aluno();
isaacBorges.Nome = "Isaac Borges";
isaacBorges.Matricula = 1213245;
isaacBorges.Curso = "Dev";
isaacBorges.Media =7.9f;

//exibicao dos dados
Console.WriteLine($"curso: {isaacBorges.Curso}");
Console.WriteLine($"Professor {sam.Nome}");
Console.WriteLine($"Identificação do Professor: {sam.NIF}");


Console.WriteLine($"aluno: {isaacBorges.Nome}");
Console.WriteLine($"idade: {isaacBorges.Idade}");
Console.WriteLine($"matricula: {isaacBorges.Matricula}");
Console.WriteLine($"media: {isaacBorges.Media}");

Carro Carro1 = new Carro();

Carro1.marca = "Volkswagen";
Carro1.modelo = "Golf GTI";


Console.WriteLine($"Marca");
Console.WriteLine($"Modelo");
Console.WriteLine($"Cor");
Console.WriteLine($"Potencia");
Console.WriteLine($"Passageiros");
Console.WriteLine($"Portas");

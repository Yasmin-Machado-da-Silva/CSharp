using System.Security.AccessControl;
using System.Security.Authentication;
using ClassesObjetos.Classes;

Console.Clear();
Console.WriteLine("**Bem-vindo ao programa ZooSharp**\n");

Animal cachorro = new Animal();
cachorro.Nome = "Spaik";
cachorro.Raça = "Shih Tzu";
cachorro.Cor = "Preto e Branco";
cachorro.Idade = 5;

Console.WriteLine("CACHORRO1");
Console.WriteLine($"Nome do cachorro: {cachorro.Nome}");
Console.WriteLine($"Idade do cachorro: {cachorro.Idade}");
Console.WriteLine($"Cor do cachorro: {cachorro.Cor}");
Console.WriteLine($"Raça do cachorro: {cachorro.Raça}\n");

Animal cachorro2 = new Animal();
cachorro2.Nome = "Órion";
cachorro2.Raça = "Doberman";
cachorro2.Cor = "Preto e marrom";
cachorro2.Idade = 6;

Console.WriteLine("CACHORRO2");
Console.WriteLine($"Nome do cachorro: {cachorro2.Nome}");
Console.WriteLine($"Idade do cachorro: {cachorro2.Idade}");
Console.WriteLine($"Cor do cachorro: {cachorro2.Cor}");
Console.WriteLine($"Raça do cachorro: {cachorro2.Raça}\n");

Console.WriteLine("INFORMAÇÕES CACHORRO1");
Console.WriteLine($"Nome do cachorro: {cachorro.Nome}");
Console.WriteLine($"Idade do cachorro: {cachorro.Idade}");
Console.WriteLine($"Cor do cachorro: {cachorro.Cor}");
Console.WriteLine($"Raça do cachorro: {cachorro.Raça}");
cachorro.FazerBarulho("WOOF WOOF");
Console.WriteLine($"Idade de {cachorro.Nome} é {cachorro.Idade}");
cachorro.Envelhecer();
Console.WriteLine($"Idade de {cachorro.Nome} após envelhecer é {cachorro.Idade}\n");

Console.WriteLine("INFORMAÇÕES CACHORRO2");
Console.WriteLine($"Nome do cachorro: {cachorro2.Nome}");
Console.WriteLine($"Idade do cachorro: {cachorro2.Idade}");
Console.WriteLine($"Cor do cachorro: {cachorro2.Cor}");
Console.WriteLine($"Raça do cachorro: {cachorro2.Raça}");
cachorro2.FazerBarulho("AUAU");
Console.WriteLine($"Idade de {cachorro2.Nome} é {cachorro2.Idade}");
cachorro2.Envelhecer();
Console.WriteLine($"Idade de {cachorro2.Nome} após envelhecer é {cachorro2.Idade}");

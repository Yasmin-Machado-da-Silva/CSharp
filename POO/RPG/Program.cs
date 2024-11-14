using RPG.Classes;

Console.WriteLine($"* Bem Vindo ao RPG * ");
Console.WriteLine("");

Personagem personagem= new Personagem();

Console.WriteLine($"Digite o nome do personagem: ");
personagem.Nome = Console.ReadLine();

Console.WriteLine("Digite a idade do seu personagem:");
 personagem.Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o nome da Armadura de seu personagem: ");
personagem.Armadura = Console.ReadLine();

Console.WriteLine($"Informe a I.A que o personagem utiliza:: ");
personagem.IA = Console.ReadLine();

Console.WriteLine($"");

Console.WriteLine($"{personagem.Nome}");
Console.WriteLine($"{personagem.Idade}");
Console.WriteLine($"{personagem.Armadura}");
Console.WriteLine($"{personagem.IA}");


Console.WriteLine($"");


personagem.Atacar();
personagem.Defender();
personagem.RestaurarArmadura();
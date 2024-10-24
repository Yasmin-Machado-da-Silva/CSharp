//Criar um cabeçalho de boas vindas
//Pedir dados do cadastro
//nome
//data de nascimento
//email
//telelefone
//CPF
//endereço
//idade - calcular baseado na sata de nascimento
//Estado civil

//Cabeçalho
Console.WriteLine(@"
                    #-----------------------------------------------#
                    |                   Boas vindas                 |
                    =-----------------------------------------------=                                               
                    |            Digite seus dados abaixo:          |                
                    |                                               |
                    #-----------------------------------------------#
                 ");

//Variaveis e tipos de dados//
Console.WriteLine($"Ola digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Ola {nome} qual eh seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine($"Ola digite sua data de nascimento: ");
string data = Console.ReadLine();

Console.WriteLine($"Ola digite seu email: ");
string email = Console.ReadLine();

Console.WriteLine($"Ola digite seu telefone: ");
UInt128 telefone = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Ola digite seu CPF: ");
UInt128 CPF = UInt128.Parse(Console.ReadLine()!);

Console.WriteLine($"Ola digite seu endereço: ");
string endereço = Console.ReadLine();

Console.WriteLine($"Em que ano voce nasceu?: ");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;
Console.WriteLine($"Você tem {idade} anos.");
Console.ReadLine();

Console.WriteLine($"Ola digite seu estado civil: ");
string estadocivil = Console.ReadLine();


Console.Clear ();


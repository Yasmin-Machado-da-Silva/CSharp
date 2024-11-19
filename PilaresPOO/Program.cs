using PilaresPOO.Classes.Pilares;

Console.Clear();
ContaCorrente ctYas= new ContaCorrente();

ctYas.Titular = "Yasmin Machado da Silva";
ctYas.BotaSaldoAi(1000000f);

Console.WriteLine($"Titular da conta {ctYas.Titular}");
Console.WriteLine($"Saldo da conta: {ctYas.getSaldo()}");

float valorSacado = ctYas.Sacar (1200f);

Console.WriteLine($"Valor do Saque: {valorSacado}");
Console.WriteLine($"Novo saldo: {ctYas.getSaldo()}");



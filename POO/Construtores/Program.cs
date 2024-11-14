using Classes.Contrutores;

Veiculo carro1 = new Veiculo( "Ford", "Ka", 2000, "Vermelho");
Veiculo carro2 = new Veiculo( "Ford", "Mustang", 1995, "Preto");

carro1.ExibirDados ();
carro2.ExibirDados ();

List <Jogo> estoqueJogos = new List<Jogo> ();

Jogo c0Duty = new Jogo( "Call of Duty", 2003, "Ação", 23);
Jogo c0DutyColossus = new Jogo( "Call of Duty - Shadow of The Colossus", 2005, "Ação", 90);

estoqueJogos.Add (c0Duty);
estoqueJogos.Add(c0DutyColossus);

foreach (var jogo in estoqueJogos) {
 jogo.ExibirDados();
 Console.WriteLine();
}

Console.WriteLine();

List <Aluno> Pessoas = new List<Aluno> ();

Aluno aluno1 = new Aluno ("Vania", 14, 1);
Aluno aluno2 = new Aluno ("Lorena", 14, 2);

Pessoas.Add (aluno1);
Pessoas.Add(aluno2);

foreach (var aluno in Pessoas) {
    aluno.ExibirDados();
    Console.WriteLine();
    
}
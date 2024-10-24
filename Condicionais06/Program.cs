

Console.WriteLine
(@"
#---------------------------------------#
|               BEM-VINDO               |
#---------------------------------------#
|    Este é o programa de media e falta |
|  dos alunos, responda aos dados pedi  |
|  -dos abaixo e veja seu resultado:    |
#---------------------------------------#
");

Console.WriteLine($"Qual a media do aluno?");
float media = float.Parse (Console.ReadLine());

Console.WriteLine($"Qual a frquencia do aluno?");
float frequencia = float.Parse (Console.ReadLine());


if (frequencia >= 75){
    
    if (media >= 7 ){
        Console.WriteLine($"Aluno aprovado");
        
    }else if (media >= 3 &&- media < 7){
        Console.WriteLine($"Aluno de recuperação");
        
    }else  {
        Console.WriteLine($"Aluno reprovado");
        
    }
}else {
    Console.WriteLine($"Aluno reprovado por faltas");
    
}








// Escreva um programa que leia as medidas dos lados de um triângulo e escreva se ele é Equilátero, Isósceles ou Escaleno. Sendo que:     

//− Triângulo Isóscele:possui 2 lados iguais.     
//− Triângulo Escaleno:possui 3 lados diferentes.
//− Triângulo Equilátero:possui os 3 lados iguais.

Console.WriteLine
(@"
#---------------------------------------#
|               BEM-VINDO               |
#---------------------------------------#
|    Este é o programa de triangulos,   |
|  responda aos dados pedidos abaixo e  |
|  veja seu resultado:                  |
#---------------------------------------#
");

int equilatero =3;
int isoceles =2;
int escaleno =3;
int resultado ;

Console.WriteLine("Qual as medidas do seu triangulo ?");
resultado = int.Parse(Console.ReadLine());
Console.WriteLine("");

if (resultado >= equilatero)
{
     Console.WriteLine("Triângulo    Equilátero");
   
} else if (resultado <= isoceles)
{
    Console.WriteLine("Triângulo    isoceles");
} else {
   Console.WriteLine("seu Triângulo  pode ser ou  escaleno ou isoceles");
}
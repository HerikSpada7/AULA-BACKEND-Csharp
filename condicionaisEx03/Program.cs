Console.WriteLine("Digite o valor do primeiro lado:");
int lado1 = int.Parse((Console.ReadLine())!);

Console.WriteLine("Digite o valor do segundo lado:");
int lado2 = int.Parse((Console.ReadLine())!);

Console.WriteLine("Digite o valor do terceiro lado:");
int lado3 = int.Parse(Console.ReadLine()!);

if (lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine("O triângulo é Equilátero.");
}
else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
{
    Console.WriteLine("O triângulo é Isósceles.");
}

else
{
    Console.WriteLine("O triângulo é Escaleno.");
}
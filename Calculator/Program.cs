using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using Calculator.Classes;

Console.Clear();

Console.WriteLine($"Bem vindo a sua calculadora online!");
Console.WriteLine();

Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite o segundo numero:");
float n2 = float.Parse(Console.ReadLine());



Calculadora calc = new Calculadora();

calc.numero1 = n1;

calc.numero2 = n2;


Console.WriteLine(@$"
    ---Qual a sua conta?---

    -Opcões-

    1-Somar
    2-Subtrair
    3-Multiplicar
    4-Dividir
");

Console.WriteLine($"Qual a sua opção?");
int Escolha = int.Parse(Console.ReadLine()!);
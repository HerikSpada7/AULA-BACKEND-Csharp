using Calculator.Classes;

Console.Clear();
Console.Clear();

Console.WriteLine($"Bem vindo a sua calculadora online!");
Console.WriteLine();

Console.WriteLine($"Digite o primeiro numero:");
float n1 = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo numero:");
float n2 = float.Parse(Console.ReadLine()!);


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

Console.WriteLine();

if(Escolha == 1){
    calc.Somar();
}

else if(Escolha == 2){
    calc.Subtrair();
}

else if(Escolha == 3){
    calc.Multiplicar();
}

else if(Escolha == 4){
    calc.Dividir();
}

else{
    Console.WriteLine($"=== Nenhuma das opções foi escolhida :( ===");
    
}


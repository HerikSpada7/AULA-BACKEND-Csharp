﻿int QtdMulher = 0;
int QtdHomem = 0;
int somaIdadeHomem = 0;
int somaIdadeMulher = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Qual é o seu sexo? m/f");
    string sexo = Console.ReadLine();

    Console.WriteLine($"Qual a sua idade?");
    int idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Qual o seu peso?");
    int peso = int.Parse(Console.ReadLine()!);


    if (sexo == "m")
    {
        QtdHomem++;

        // a *somaIdadeHomem* soma ou iguala a idade adicionando ela a cada vez que passa
        somaIdadeHomem += idade;
    }
    else
    {
        QtdMulher++;
        somaIdadeMulher += idade;
    }
}


// soma de todas as idades e dividir pelas pessoas no caso 10
float mediaHomem = somaIdadeHomem / QtdHomem;
float mediaMulher = somaIdadeMulher / QtdMulher;


Console.WriteLine($"Quantidades total de homens: {QtdHomem}");
Console.WriteLine($"Quantidades total de mulheres: {QtdMulher}");
Console.WriteLine($"Idade media dos homens: {mediaHomem}");
Console.WriteLine($"Idade media das mulheres: {mediaMulher}");
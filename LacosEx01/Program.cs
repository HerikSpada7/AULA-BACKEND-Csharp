Console.WriteLine(@$"
----------------------------------------
|         Bem vindo ao programa        |
|              Contador                |
|                 De                   |
|               Pessoas                |
----------------------------------------
");



int QtdMulher = 0;
int QtdHomem = 0;
int QtdGostaEsporte = 0;
int QtdNaoGostaEsporte = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa?");
int QtdEntrevistados = int.Parse(Console.ReadLine()!);


for (int i = 1; i <= QtdEntrevistados; i++)
{
    Console.WriteLine($"Qual é o seu sexo ? m/f");
    string sexo = Console.ReadLine();



    if (sexo == "f")
    {
        QtdMulher++;
    }
    else
    {
        QtdHomem++;
    }

    Console.WriteLine($"Você gosta de esporte? sim/nao");
    string esporte = Console.ReadLine();

    if (esporte == "sim")
    {
        QtdGostaEsporte++;
    }
    else
    {
        QtdNaoGostaEsporte++;
    }
}

float totalgostaesporte = 100 / QtdEntrevistados * QtdGostaEsporte;
float totalnaogostaesporte = 100 / QtdEntrevistados * QtdNaoGostaEsporte;

Console.WriteLine($"Quantidade de Mulheres: {QtdMulher}");
Console.WriteLine($"Quantidade de Homens: {QtdHomem}");
Console.WriteLine($"Total de pessoas que gostaram de esporte: {QtdGostaEsporte}");
Console.WriteLine($"Total de pessoas que não gostam de esporte: {QtdNaoGostaEsporte}");
Console.WriteLine($"Total de Entrevistados: {QtdHomem + QtdMulher}");
Console.WriteLine($"A % de pessoas que gostam: {totalgostaesporte}%");
Console.WriteLine($"A % de pessoas que não gostam: {totalnaogostaesporte}%");







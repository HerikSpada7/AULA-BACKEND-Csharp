int QtdEntrevistados = 10;
int QtdGostaProduto = 0;
int QtdNaoGostaProduto = 0;
int QtdMulheres = 0;
int QtdMulheresGosta = 0;
int QtdHomens = 0;
int QtdHomensNaoGosta = 0;




for (int i = 1; i <= QtdEntrevistados; i++)
{

    Console.WriteLine($"Qual o seu sexo? m/f");
    string sexo = Console.ReadLine();

    if (sexo == "m")
    {
        QtdHomens++;
    }
    else
    {
        QtdMulheres++;
    }

    Console.WriteLine($"Você gostou do determinado produto? sim/nao");
    string gostaProduto = Console.ReadLine();


    if (gostaProduto == "sim")
    {
        QtdGostaProduto++;
        QtdMulheresGosta++;
    }

    else
    {
        QtdNaoGostaProduto++;
        QtdHomensNaoGosta++;
    }

}

float QtdPorcNaoGostaHomens = 100 / QtdEntrevistados * QtdHomensNaoGosta;

Console.WriteLine(@$"
===============================================================================================
===============================================================================================

");


Console.WriteLine($"O número de pessoas que responderam SIM: {QtdGostaProduto}");
Console.WriteLine($"O número de pessoas que responderam NÃO: {QtdNaoGostaProduto}");
Console.WriteLine($"O número de mulheres que responderam SIM: {QtdMulheresGosta}");
Console.WriteLine($"A porcentagem de homens que responderam NÃO entre todos os homens analisados: {QtdPorcNaoGostaHomens}%");
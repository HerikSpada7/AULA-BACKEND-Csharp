Console.WriteLine($"Primeiro time:");
string time1 = Console.ReadLine()!;

Console.WriteLine($"Segundo time:");
string time2 = Console.ReadLine()!;

Console.WriteLine($"Quantos gols o {time1} fez:");
int golsTime1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Quantos gols o {time2} fez:");
int golsTime2 = int.Parse(Console.ReadLine()!);

if (golsTime1 > golsTime2){
    Console.WriteLine($"{time1} Venceu o jogo com o placar de: {time1} {golsTime1} - {golsTime2} {time2}");
}

else if (golsTime1 < golsTime2){
    Console.WriteLine($"{time2} Venceu o jogo com o placar de: {time2} {golsTime2} - {golsTime1} {time1}");    
}

else{
    Console.WriteLine($"O jogo empatou com o placar de: {time1} {golsTime1} - {golsTime2} {time2}");
}
int[] temperatura = new int[12];

for (int i = 0; i < 12; i++)
{
    Console.WriteLine($"Digite a temperatura média do mês {i + 1}: ");
    temperatura[i] = int.Parse(Console.ReadLine()!);
}

int maiorTemperatura = temperatura.Max();
int menorTemperatura = temperatura.Min();

Console.WriteLine($"A maior temperatura do ano foi: {maiorTemperatura}");
Console.WriteLine($"A menor temperatura do ano foi: {menorTemperatura}");


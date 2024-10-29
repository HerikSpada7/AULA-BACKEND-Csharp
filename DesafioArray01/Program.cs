int [] numeros = new int [6];
int par = 0;
int impar = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Digite um {i + 1}º número");
    int numeroDigitado = int.Parse(Console.ReadLine()!);
    numeros[i] = numeroDigitado;

    if (numeroDigitado %2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }

}

Console.Clear();

Console.WriteLine($"{par} número(s) par (es): ");
for (int i = 0; i < numeros.Length; i++)
{
    if(numeros[i] %2 == 0 ){
        Console.WriteLine($"{numeros[i]}");

    }
}
Console.WriteLine($"{impar} número(s) impar (es): ");
for (int i = 0; i < numeros.Length; i++)
{
      if(numeros[i] %2 == 1 ){
        Console.WriteLine($"{numeros[i]}");

    }
}
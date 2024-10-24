Console.WriteLine($"Digite seu salario: ");
float salario = float.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o total gasto dese mês:");
float totalGasto = float.Parse(Console.ReadLine()!);

if(salario >= totalGasto){
    Console.WriteLine($"*Gastos dentro do orçamento!*");
}

else{
    Console.WriteLine($"*Orçamento estourado!*");
}